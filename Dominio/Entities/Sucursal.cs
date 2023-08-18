using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Sucursal
    {
        [Key]
        public int  IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public string TelefonoSucursal { get; set; }
    }
