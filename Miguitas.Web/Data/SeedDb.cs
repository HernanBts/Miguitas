namespace Miguitas.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;


    public class SeedDb
    {
        private readonly DataContext context;
        private readonly UserManager<User> userManager;
        private readonly Random random;

        public SeedDb(DataContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userManager.FindByEmailAsync("admin@miguitas.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "admin",
                    LastName = "admin",
                    Email = "admin@miguitas.com",
                    UserName = "admin@miguitas.com"
                };

                var result = await this.userManager.CreateAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this.context.Products.Any())
            {
                this.AddProduct("Combo Clasico", user);
                this.AddProduct("Combo Especial", user);
                this.AddProduct("Combo Premium", user);
                await this.context.SaveChangesAsync();
            }
        }


        private void AddProduct(string name, User user)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Description = $"Posee los ingredientes de {name}...",
                Price = this.random.Next(500),
                IsAvailable = true,
                Stock = this.random.Next(100),
        	    User = user
            });
        }
    }

}
