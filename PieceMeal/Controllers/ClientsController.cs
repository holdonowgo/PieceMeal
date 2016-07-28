using System.Web.Mvc;

namespace PieceMeal.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Create()
        {
            return View();
        }
    }
}