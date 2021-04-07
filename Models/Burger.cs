using System;
using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
  public class Burger
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Range(0, 1000)]
    public decimal? Price { get; set; }
    public int Id { get; set; }


  }
}