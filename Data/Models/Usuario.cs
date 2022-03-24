using System;
using System.Collections.Generic;

namespace HagenApi.Data.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            DatosUsuarios = new HashSet<DatosUsuario>();
        }

        public int IdUsuario { get; set; }
        public string Correo { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<DatosUsuario> DatosUsuarios { get; set; }
    }
}
