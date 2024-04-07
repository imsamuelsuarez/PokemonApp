using Microsoft.AspNetCore.Mvc;

namespace PokemonApp.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
