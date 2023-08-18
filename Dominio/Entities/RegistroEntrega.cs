using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;

    public class RegistroEntrega
    {
        [Key]
        public int IdRegistro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal CombustibleEntregado { get; set; }
        public int KilometrajeEntregado { get; set; }
    
    }