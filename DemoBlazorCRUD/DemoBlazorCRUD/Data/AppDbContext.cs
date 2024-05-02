using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace DemoBlazorCRUD.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<HealthEdu> HealthEdu { get; set; }
    }
}
