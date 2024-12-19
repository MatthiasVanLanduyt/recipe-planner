using Domain.Shared;

namespace Domain.Recipes
{
    public class Ingredient
    {
        public Product Product { get; set; }
        public Unit Unit { get; set; }
        public decimal Quantity { get; set; }
    }
}
