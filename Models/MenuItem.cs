using System.ComponentModel.DataAnnotations;
using burgershack.Interfaces;

namespace burgershack.Models
{
  //NOTE removed abstract to properly return in repository
  public class MenuItem : IPurchasable
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int CalMax { get; set; }
    [Required]
    public string Category { get; set; }
  }
}