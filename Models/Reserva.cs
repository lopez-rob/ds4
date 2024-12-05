namespace ReserViento.Models
{
    public class Reserva
    {
        public string NombreCompleto { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadAdultos { get; set; }
        public bool HayMenores { get; set; }
        public int? CantidadMenores { get; set; }
    }
}
