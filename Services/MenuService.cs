using System;
using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services
{
  public class MenuService
  {
    private readonly MenuRepository _repo;

    public MenuService(MenuRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<IPurchasable> getAll()
    {
      var data = _repo.GetAll();
      return data;
    }
  }
}