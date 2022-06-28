using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Model;

namespace WebAPIDemo.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}

