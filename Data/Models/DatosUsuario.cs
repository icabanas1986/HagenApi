using System;
using System.Collections.Generic;

namespace HagenApi.Data.Models
{
    public partial class DatosUsuario
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? EstadoCivil { get; set; }
        public string? Telefono { get; set; }
        public int? Pais { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public string? Direccion { get; set; }
        public int? Nacionalidad { get; set; }
        public string? Contraseña { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool? AceptaTerminos { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
