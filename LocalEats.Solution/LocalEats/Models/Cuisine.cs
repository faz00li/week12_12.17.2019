using System.Collections.Generic;

namespace LocalEats.Models
{
  public class Cuisine
  {
    public int CuisineId {get; set;}
    public string CuisineType {get; set;}
    public virtual ICollection<Cafe> Cafes {get; set;}

    public Cuisine()
    {
      this.Cafes = new HashSet<Cafe>();
    }
  }
}
