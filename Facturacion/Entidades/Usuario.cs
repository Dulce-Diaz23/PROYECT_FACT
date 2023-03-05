using System;

namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public byte[] foto { get; set; }  // guardar foto BD
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Usuario()
        {

        }

        public Usuario(string codigoUsuario, string nombre, string contrasena, string correo, string rol, byte[] foto, bool estaActivo, DateTime fechaCreacion)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            Rol = rol;
            this.foto = foto;
            EstaActivo = estaActivo;
            FechaCreacion = fechaCreacion;
        }
    }
}
