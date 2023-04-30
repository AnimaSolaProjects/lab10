using System.Data.Entity;

namespace lab10.Model
{
    public class UserContext : DbContext
    {
        public UserContext() :base("DbConnection")
        { }
        public DbSet<Beer> Beers { get; set; }

        public DbSet<Сompany> Сompanies { get; set; }
    }
}
