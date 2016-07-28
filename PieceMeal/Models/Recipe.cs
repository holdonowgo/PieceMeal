using System.ComponentModel.DataAnnotations;

namespace PieceMeal.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        //public List<ClientRecipe> ClientRecipes { get; set; }
        public Cuisine Cuisine { get; set; }
        public MealType MealType { get; set; }
    }
}