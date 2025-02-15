using Microsoft.EntityFrameworkCore;
using SimpleCRUDApp.Models;

namespace SimpleCRUDApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
