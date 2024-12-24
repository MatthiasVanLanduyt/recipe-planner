using Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace console.Recipes
{
    public class RecipeSeeder
    {
        public static List<Product> SeedProducts()
        {
            var products = new List<Product>();

            products.Add(new Product
            {
                Name = "Flour",
            });

            products.Add(new Product
            {
                Name = "Sugar",
            });

            products.Add(new Product
            {
                Name = "Eggs",
            });

            products.Add(new Product
            {
                Name = "Butter",
            });

            products.Add(new Product
            {
                Name = "Milk",
            });

            products.Add(new Product
            {
                Name = "Baking Powder",
            });

            products.Add(new Product
            {
                Name = "Salt",
            });

            products.Add(new Product
            {
                Name = "Vanilla Extract",
            });

            products.Add(new Product
            {
                Name = "Chocolate Chips",
            });

            products.Add(new Product
            {
                Name = "Tomato",
            });

            products.Add(new Product
            {
                Name = "Onion",
            });

            products.Add(new Product
            {
                Name = "Garlic",
            });

            products.Add(new Product
            {
                Name = "Chicken",
            });

            return products;

        }

        public static List<Recipe> SeedRecipes()
        {
            return new List<Recipe> { Recipes.Pancakes, Recipes.Pizza };
        }
    }
}
