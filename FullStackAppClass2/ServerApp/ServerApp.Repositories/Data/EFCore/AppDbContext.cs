using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Deparments { get; set; }
    }
}
