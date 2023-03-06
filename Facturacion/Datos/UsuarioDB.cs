using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=diaz";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;     //declarando usuario
            try                           //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.Contrasena;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();   //Intanciando usuario

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contrasena = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.Foto = (byte[])dr["Foto"];
                            user.EstaActivo = Convert.ToBoolean(dr["Esta activo"]);
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return user;
        }
    }
}
