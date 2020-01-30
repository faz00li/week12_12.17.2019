namespace LocalEats.Models
{
  public class Cafe
  {
    public int CafeId {get; set;}
    public string CafeName {get; set;}
    public string Owner {get; set;}
    public string Description {get; set;}

    public int CuisineId {get; set;}
    public virtual Cuisine Cuisine {get; set;}
  }
}
