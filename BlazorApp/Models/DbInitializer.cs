namespace BlazorApp.Models
{
    public class DbInitializer
    {
        internal static void SeedData(BlazorAppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Inventories.Any())
            {
                return;
            }

            var inventories = Inventory.ProcessFile("Data/inventories.csv");
            context.Inventories.AddRange(inventories);
            context.SaveChanges();

            var themes = Theme.ProcessFile("Data/themes.csv");
            context.Themes.AddRange(themes);
            context.SaveChanges();

            var parts = Part.ProcessFile("Data/parts.csv");
            context.Parts.AddRange(parts);
            context.SaveChanges();

            var partCategories = PartCategory.ProcessFile("Data/part_categories.csv");
            context.PartCategories.AddRange(partCategories);
            context.SaveChanges();

            var sets = BlazorApp.Models.Set.ProcessFile("Data/sets.csv");
            context.Sets.AddRange(sets);
            context.SaveChanges();

            var colors = Color.ProcessFile("Data/colors.csv");
            context.Colors.AddRange(colors);
            context.SaveChanges();

            var inventoryParts = InventoryPart.ProcessFile("Data/inventory_parts.csv");
            context.InventoryParts.AddRange(inventoryParts);
            context.SaveChanges();
        }
    }
}
