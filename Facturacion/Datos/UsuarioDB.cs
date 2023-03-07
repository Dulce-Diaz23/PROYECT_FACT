using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=diaz;";

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
                            user.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.Foto = (byte[])dr["Foto"];
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return user;
        }

        // metodo para manipular usuarios
        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try                                                   //Capturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("INSERT INTO usuario VALUES ");
                sql.Append(" (@CodigoUsuario, @Nombre, @Contrasena, @Rol, @FechaCracion, @EstaActivo, @Correo)");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.ExecuteNonQuery();
                        inserto = true;

                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return inserto;
        }

        // Metodo
        public bool Editar(Usuario user)
        {
            bool edito = false;
            try                                                   //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("UPDATE usuario SET ");
                sql.Append(" (Nombre = @Nombre, Contrasena = @Contrasena, Rol = @Rol, EstaActivo =  @EstaActivo, Correo = @Correo)");
                sql.Append("WHERE CodigoUsuario = @CodigoUsuario"); // indica que ususario se va a modificar

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.Datetime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.ExecuteNonQuery();
                        edito = true;

                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return edito;
        }

        public bool Eliminar(string codigoUsuario)
        {
            bool elimino = false;
            try                                                   //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("DELETE FROM usuario");
                sql.Append("WHERE CodigoUsuario = @CodigoUsuario"); // indica que ususario se va a modificar

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        comando.ExecuteNonQuery();
                        elimino = true;
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return elimino;
        }

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();
            try                                                   //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("SELECT * FROM usuario");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);    //llenar tabla
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return dt;
        }



    }


}






