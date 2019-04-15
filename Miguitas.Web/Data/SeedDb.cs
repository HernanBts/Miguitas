namespace Miguitas.Web.Data
{
    using Entities;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Products.Any())
            {
                this.AddProduct("Combo Clasico");
                this.AddProduct("Combo Especial");
                this.AddProduct("Combo Premium");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Description = $"Posee los ingredientes de {name}...",
                Price = this.random.Next(500),
                IsAvailable = true,
                Stock = this.random.Next(100)
            });
        }
    }

}
