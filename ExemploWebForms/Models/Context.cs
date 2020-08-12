using System.Data.Entity;

namespace ExemploWebForms.Models
{
    public class Context : DbContext
    {
        public Context() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}