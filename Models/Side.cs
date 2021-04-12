using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Side : MenuItem, ISize
  {

    public Side()
    {
      Category = "Side";
    }

    public string Size { get; set; }
  }
}