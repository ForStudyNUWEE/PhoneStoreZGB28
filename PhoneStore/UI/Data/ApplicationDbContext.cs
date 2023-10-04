using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Other { get; set; }
        //Navigation properties
        public List<Product> Products { get; set; } = new List<Product>();

    }
    public class Product
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }
        public string Other { get; set; }
        public int ManufacturerId { get; set; }
        //Navigation properties
        public Manufacturer Manufacturer { get; set; }

    }
}