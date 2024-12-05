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

        // Aquí puedes agregar más acciones para manejar reservas u otras funcionalidades
    }
}
