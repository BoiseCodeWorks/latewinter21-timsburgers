using System;
using System.Collections.Generic;
using System.Data;
using burgershack.Interfaces;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class MenuRepository
  {
    private readonly IDbConnection _db;

    public MenuRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<MenuItem> GetAll()
    {
      // REVIEW 
      // dapper is creating an instance of the class so it requires a non-abstract class. the fix for today was to make the menu item class non abstract, you can still inherit from it,
      //but now it can be instantiated on its own and map the burgers/drinks/sides propertys over properly. 
      // In our use case here we need dapper to create them on the so it is okay to have it not abstract. 
      //ultimately if we wanted to keep the class as abstract, we would query our 3 tables independantly and then cast the results to MenuItem if we wanted that one big collection.
      //this solution is more complicated and leads us down another rabbit hole.
      // since our tables have different columns, you can specificy the colums you want to select from each table and then form a UNION with another table to bring in the data from that table.
      // this will now just grab the name, price, and id from the 3 tables, cast them to MenuItems and retun the full collection.
      //if our tables had the same columns then we could use SELECT * but since there is differences between burgers - drinks/sides we need to specify the columns we want to retrieve.
      string sql = @"SELECT 
      burgers.name, 
      burgers.price, 
      burgers.id FROM burgers 
      UNION SELECT 
      drinks.name, 
      drinks.price, 
      drinks.id FROM drinks 
      UNION SELECT 
      sides.name, 
      sides.price, 
      sides.id FROM sides;";
      return _db.Query<MenuItem>(sql);
    }
  }
}