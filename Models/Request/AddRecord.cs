namespace HagenApi.Models.Request
{
    public class AddRecord
    {
        public string correo { get; set; }
        public string contrasena { get; set; }
    }

    public class AddPersonal
    {
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido { get; set; }
        public string Apellido2 { get; set; }
        public DateTime Nacimiento { get; set; }
        public string telefono { get; set; }
        public int EstadoCivil { get; set; }
        public int idPais { get; set; }
        public int idEstado { get; set; }
        public int idMunicipio { get; set; }
        public string Direccion { get; set; }
        public int Nacionalidad { get; set; }
        public bool AceptaTerminos { get; set; }
    }
    
}