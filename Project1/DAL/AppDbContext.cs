using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project1.Models;

namespace Project1.DAL
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=DESKTOP-5OFP8O5\\SQLEXPRESS ;  Database=Pronia ; Trusted_Connection=True; Encrypt=False;");
             base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products { get; set; }
    }
}
