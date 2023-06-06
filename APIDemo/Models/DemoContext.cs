using Microsoft.EntityFrameworkCore;

namespace APIDemo.Models
{
    public class DemoContext: DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) 
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
