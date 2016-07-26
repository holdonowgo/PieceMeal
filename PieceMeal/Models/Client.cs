using System;
using System.ComponentModel.DataAnnotations;

namespace PieceMeal.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Account { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateTime { get; set; }
        //public List<ClientRecipe> ClientRecipe { get; set; }

    }
}