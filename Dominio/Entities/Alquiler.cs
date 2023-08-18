using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        public DateTime FechaInicioAlquiler { get; set; }
        public DateTime FechaFinAlquiler { get; set; }
        public decimal CostoTotal { get; set; }
        public string Estado { get; set; }
    }
