namespace ReserViento.Models
{
    public class Habitacion
    {
        public string Tipo { get; set; } // Tipo de recámara (Estándar, Individual, etc.)
        public string Descripcion { get; set; } // Descripción breve
        public string Vista { get; set; } // Vista desde la habitación (Jardín, Mar, etc.)
        public decimal Precio { get; set; } // Precio por noche
    }
}
