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

        public ActionResult Create()
        {
            var viewModel = new RecipeFormViewModel
            {
                Cuisines = _context.Cusines.ToList(),
                MealTypes = _context.MealTypes.ToList()
            };

            return View(viewModel);
        }
    }
}