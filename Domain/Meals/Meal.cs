using Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Meals
{
    public record Meal
    {
        public Recipe Recipe { get; set; }
        public DateOnly Date { get; set; }
    }
}
