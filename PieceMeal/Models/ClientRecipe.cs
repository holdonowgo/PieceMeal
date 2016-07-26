using System.ComponentModel.DataAnnotations;

namespace PieceMeal.Models
{
    public class ClientRecipe
    {
        [Key]
        public int ClientId { get; set; }

        [Key]
        public int RecipeId { get; set; }
    }
}