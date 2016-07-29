using PieceMeal.Models;
using PieceMeal.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace PieceMeal.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new RecipeFormViewModel
            {
                Cuisines = _context.Cusines.ToList(),
                MealTypes = _context.MealTypes.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(RecipeFormViewModel viewModel)
        {
            var cuisine = _context.Cusines.Single(c => c.Id == viewModel.Cuisine);
            var mealType = _context.MealTypes.Single(c => c.Id == viewModel.MealType);
            var recipe = new Recipe
            {
                CuisineId = viewModel.Cuisine,
                Description = viewModel.Description,
                MealTypeId = viewModel.MealType,
                Name = viewModel.Name
            };

            _context.Recipes.Add(recipe);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}