
using Microsoft.EntityFrameworkCore;
using OfficeItemManagement.Data.Model;

namespace OfficeItemManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Export> Export { get; set; }
        public DbSet<Import> Import { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<ProductionRegion> ProductionRegion { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User {Id = 1,Username = "admin", Name = "管理员", Password = "0000"});
        }
    }
}