using Microsoft.AspNetCore.Mvc;
using ReserViento.Models;
using System.Collections.Generic;

namespace ReserViento.Controllers
{
    public class ReservasController : Controller
    {
        // Acción para mostrar el formulario de reserva
        public IActionResult Index()
        {
            return View();
        }

        // Acción para manejar las recámaras según el hotel seleccionado
        public IActionResult Recamara(string hotel)
        {
            ViewData["Hotel"] = hotel;

            // Simula una lista de habitaciones según el hotel seleccionado
            var habitaciones = new List<Habitacion>
            {
                new Habitacion
                {
                    Tipo = "Recámara Estándar",
                    Descripcion = "Cama Queen, baño privado, amenities premium, vista al jardín.",
                    Vista = "Jardín",
                    Precio = 85
                },
                new Habitacion
                {
                    Tipo = "Recámara Individual",
                    Descripcion = "Cama individual, baño privado, amenities básicos, vista al mar.",
                    Vista = "Mar",
                    Precio = 55
                }
            };

            return View(habitaciones);
        }
    }
}
