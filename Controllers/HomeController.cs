using Microsoft.AspNetCore.Mvc;

namespace ReserViento.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Aqu� puedes agregar m�s acciones para manejar reservas u otras funcionalidades
    }
}
