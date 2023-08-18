using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreEpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string DniEmpleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string CargoEmpleado { get; set; }
    }
