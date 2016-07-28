using PieceMeal.Models;
using System.Collections.Generic;

namespace PieceMeal.ViewModels
{
    public class RecipeFormViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cuisine { get; set; }
        public int MealType { get; set; }

        public IEnumerable<Cuisine> Cuisines { get; set; }

        public IEnumerable<MealType> MealTypes { get; set; }
    }
}