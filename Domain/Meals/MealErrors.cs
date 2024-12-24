using SharedKernel;

namespace Domain.Meals
{
    public static class MealErrors
    {
        public static Error DateAlreadyPlanned => new Error("Meals.DateAlreadyPlanned", "There is already a meal planned for this date.", ErrorType.Conflict);
    }
}
