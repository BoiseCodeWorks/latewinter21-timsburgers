using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Drink : MenuItem, ISize
  {
    public string Size { get; set; }

    public Drink()
    {
      Category = "Drink";
    }

  }
}