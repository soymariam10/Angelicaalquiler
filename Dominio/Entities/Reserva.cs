using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
