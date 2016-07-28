using System.ComponentModel.DataAnnotations;

namespace PieceMeal.Models
{
    public class MealType
    {
        public byte Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}