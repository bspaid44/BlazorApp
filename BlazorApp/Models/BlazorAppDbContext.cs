using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Models
{
    internal class BlazorAppDbContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartCategory> PartCategories { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<InventoryPart> InventoryParts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=BlazorAppDb;Trusted_Connection=True;");
        }
    }
}
