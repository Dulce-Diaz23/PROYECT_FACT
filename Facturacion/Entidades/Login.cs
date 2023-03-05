using System;

namespace Entidades
{
    public class Login
    {
        public string CodigoUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public DateTime MyProperty { get; set; }

        public Login()
        {

        }

        public Login(string codigoUsuario, string contrasena, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Contrasena = contrasena;
            Rol = rol;
        }
    }
}
