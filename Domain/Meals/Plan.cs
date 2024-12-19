using Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Meals
{
    public class Plan
    {
        private List<Meal> _meals = new();

        public IReadOnlyCollection<Meal> Meals => _meals.AsReadOnly();

        public void RemoveMeal(Meal meal)
        {
            _meals.Remove(meal);
        }

        public void PlanMeal(Recipe recipe, DateOnly date)
        {
            var meal = new Meal
            {
                Recipe = recipe,
                Date = date
            };

            if (HasMealOnDate(date))
            {
                throw new InvalidOperationException("There is already a meal planned for this date.");
            }

            _meals.Add(meal);
        }

        private bool HasMealOnDate(DateOnly date)
        {
            return _meals.Any(m => m.Date == date);
        }
    }
}
