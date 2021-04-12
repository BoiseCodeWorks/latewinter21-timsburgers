using System;
using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Burger : MenuItem
  {
    public string Description { get; set; }

    public Burger()
    {
      Category = "Burger";
    }


  }
}