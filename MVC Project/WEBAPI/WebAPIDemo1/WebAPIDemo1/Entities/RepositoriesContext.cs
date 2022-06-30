using Microsoft.EntityFrameworkCore;
using WebAPIDemo1.Model;

namespace WebAPIDemo1.Entities
{
    public class RepositoriesContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
