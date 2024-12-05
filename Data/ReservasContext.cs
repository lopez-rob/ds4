using Microsoft.EntityFrameworkCore;
using ReserViento.Models; // Asegúrate de que esta referencia esté presente

namespace ReserViento.Data // O el espacio de nombres que estés utilizando
{
    public class ReservasContext : DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; } // Agrega tus entidades aquí
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
