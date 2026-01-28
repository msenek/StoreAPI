using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class TestApiContext : DbContext
    {
        public TestApiContext(DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
