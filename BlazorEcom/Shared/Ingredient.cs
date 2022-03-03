namespace BlazorEcom.Shared
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; } = string.Empty;

        
        public int? FoodId { get; set; } // Foreign key
        public Food? Food { get; set; } // Reference navigation
        
    }
}
