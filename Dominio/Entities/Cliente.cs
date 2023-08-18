using System.ComponentModel.DataAnnotations;
namespace Dominio.Entities;
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DniCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string EmailCliente { get; set; }
    }
