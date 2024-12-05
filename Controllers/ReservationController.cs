using Microsoft.AspNetCore.Mvc;

public class ReservationController : Controller
{
    [HttpGet]
    public IActionResult FinalizeReservation(string roomName, decimal roomPrice, int nights)
    {
        // Calcular el precio total
        decimal totalPrice = roomPrice * nights;

        // Crear un modelo con los datos de la reserva
        var reservation = new ReservationModel
        {
            RoomName = roomName,
            RoomPrice = roomPrice,
            Nights = nights,
            TotalPrice = totalPrice
        };

        // Redirigir a la vista de confirmación con el modelo
        return View("ConfirmacionReserva", reservation);
    }
}
