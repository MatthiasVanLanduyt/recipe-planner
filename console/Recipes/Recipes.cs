using Domain.Recipes;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Recipes
{
    public static class Recipes
    {
        public static Recipe Pancakes
        {
            get
            {
                var recipe = new Recipe()
                {
                    Name = "pancakes",
                    Description = "Delicious pancakes with chocolate chips."
                };

                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Flour,
                    Quantity = 100,
                    Unit = Units.Grams
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Sugar,
                    Quantity = 50,
                    Unit = Units.Grams
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Eggs,
                    Quantity = 2,
                    Unit = Units.Pieces
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Butter,
                    Quantity = 50,
                    Unit = Units.Grams
                });

                return recipe;
            }
        }

        public static Recipe Pizza
        {
            get
            {
                var recipe = new Recipe()
                {
                    Name = "pizza",
                    Description = "Delicious pizza with tomato sauce and cheese."
                };

                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Flour,
                    Quantity = 300,
                    Unit = Units.Grams
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Sugar,
                    Quantity = 10,
                    Unit = Units.Grams
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Tomato,
                    Quantity = 2,
                    Unit = Units.Pieces
                });
                recipe.AddIngredient(new Ingredient
                {
                    Product = Products.Cheese,
                    Quantity = 100,
                    Unit = Units.Grams
                });

                return recipe;
            }
        }
    }
}
