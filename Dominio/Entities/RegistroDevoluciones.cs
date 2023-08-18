using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class RegistroDevoluciones
    {
        [Key]
        public int IdRegistroDevolucion { get; set; }
        public DateTime FechaDevolcion { get; set; }
        public decimal CombustibleDevuelto { get; set; }
        public decimal KilometrajeDevuelto { get; set; }
        public decimal MontoAdicional { get; set; }
    }
