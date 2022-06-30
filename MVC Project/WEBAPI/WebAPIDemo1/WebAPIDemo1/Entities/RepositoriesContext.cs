using Microsoft.EntityFrameworkCore;
using WebAPIDemo1.Model;

namespace WebAPIDemo1.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
