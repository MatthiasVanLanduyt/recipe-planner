namespace Domain.Recipes
{
    public class Recipe
    {

        private List<Ingredient> _ingredients = [];
        private List<Instruction> _instructions = [];

        internal int Id { get; init; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients => _ingredients.AsReadOnly();

        public IReadOnlyCollection<Instruction> Instructions => _instructions.AsReadOnly();

        public Recipe()
        {
            _ingredients = new List<Ingredient>();
            _instructions = new List<Instruction>();
        }

        public Recipe(string name, string description)
        {
            _ingredients = new List<Ingredient>();
            
            Name = name;
            Description = description;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void AddIngredients(IEnumerable<Ingredient> ingredients)
        {
            _ingredients.AddRange(ingredients);
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            _ingredients.Remove(ingredient);
        }

        public void AddInstruction(Instruction instruction)
        {
            _instructions.Add(instruction);
        }

        public void AddInstructions(IEnumerable<Instruction> instructions)
        {
            _instructions.AddRange(instructions);
        }

        public void RemoveInstruction(Instruction instruction)
        {
            _instructions.Remove(instruction);
        }

    }
}
