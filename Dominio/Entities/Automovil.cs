using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Automovil
    {
        [Key]
        public int IdAutomovil { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public decimal PrecioDiario { get; set; }

    }
