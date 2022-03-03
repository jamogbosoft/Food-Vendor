using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEcom.Shared
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public virtual List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public string Instruction { get; set; } = string.Empty;
        [Column(TypeName = "float")]
        public float Price { get; set; }
    }
}