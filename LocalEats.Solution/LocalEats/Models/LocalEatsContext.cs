using Microsoft.EntityFrameworkCore;

namespace LocalEats.Models
{
  public class LocalEatsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines {get; set;}
    public DbSet<Cafe> Cafes {get; set;}

    public LocalEatsContext(DbContextOptions options) : base(options) { }
  }
}
