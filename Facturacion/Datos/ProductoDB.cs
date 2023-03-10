namespace Datos
{
    //    public class ProductoDB
    //    {
    //        string cadena = "server=localhost; user=root; database=factura; password=diaz;";


    //        // metodo para manipular usuarios
    //        public bool Insertar(Producto producto)
    //        {
    //            bool inserto = false;
    //            try                                                   //Capturar errores, evitar error inesperado
    //            {
    //                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
    //                sql.Append("INSERT INTO producto VALUES ");
    //                sql.Append(" (@CodigoProducto, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo)");
    //                using (MySqlConnection _conexion = new MySqlConnection(cadena))
    //                {
    //                    _conexion.Open();
    //                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
    //                    {

    //                        comando.CommandType = CommandType.Text;
    //                        comando.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 80).Value = producto.Codigo;
    //                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
    //                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
    //                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
    //                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
    //                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
    //                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
    //                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
    //                        comando.ExecuteNonQuery();
    //                        inserto = true;

    //                    }
    //                }
    //            }
    //            catch (System.Exception ex)
    //            {

    //            }

    //            return inserto;
    //        }

    //        // Metodo
    //        public bool Editar(Usuario user)           //ERROR
    //        {
    //            bool edito = false;
    //            try                                                   //Capturar errores, evitar error inesperado
    //            {
    //                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
    //                sql.Append("UPDATE  usuario SET ");
    //                sql.Append("  Nombre = @Nombre, Contrasena = @Contrasena, Rol = @Rol,EstaActivo = @EstaActivo, Correo = @Correo, Foto=@Foto");
    //                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario;");
    //                using (MySqlConnection _conexion = new MySqlConnection(cadena))
    //                {
    //                    _conexion.Open();
    //                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
    //                    {

    //                        comando.CommandType = CommandType.Text;
    //                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
    //                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
    //                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contrasena;
    //                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
    //                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
    //                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
    //                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
    //                        comando.ExecuteNonQuery();
    //                        edito = true;

    //                    }
    //                }
    //            }
    //            catch (System.Exception ex)
    //            {

    //            }

    //            return edito;
    //        }

    //        public bool Eliminar(string codigoUsuario)
    //        {
    //            bool elimino = false;
    //            try                                                   //Capturar errores, evitar error inesperado
    //            {
    //                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
    //                sql.Append("DELETE FROM usuario ");
    //                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario;");
    //                using (MySqlConnection _conexion = new MySqlConnection(cadena))
    //                {
    //                    _conexion.Open();
    //                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
    //                    {

    //                        comando.CommandType = CommandType.Text;
    //                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
    //                        comando.ExecuteNonQuery();
    //                        elimino = true;

    //                    }
    //                }
    //            }
    //            catch (System.Exception ex)
    //            {

    //            }

    //            return elimino;
    //        }

    //        public DataTable DevolverUsuarios()
    //        {
    //            DataTable dt = new DataTable();
    //            try                                                   //Capaturar errores, evitar error inesperado
    //            {
    //                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
    //                sql.Append("SELECT * FROM usuario");
    //                using (MySqlConnection _conexion = new MySqlConnection(cadena))
    //                {
    //                    _conexion.Open();
    //                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
    //                    {
    //                        comando.CommandType = CommandType.Text;
    //                        MySqlDataReader dr = comando.ExecuteReader();
    //                        dt.Load(dr);    //llenar tabla
    //                    }
    //                }
    //            }
    //            catch (System.Exception ex)
    //            {

    //            }

    //            return dt;
    //        }

    //        public byte[] DevolverFoto(string codigoUsuario)
    //        {
    //            byte[] foto = new byte[0];

    //            try                                                   //Capaturar errores, evitar error inesperado
    //            {
    //                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
    //                sql.Append("SELECT Foto FROM usuario WHERE CodigoUsuario = @CodigoUsuario");
    //                using (MySqlConnection _conexion = new MySqlConnection(cadena))
    //                {
    //                    _conexion.Open();
    //                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
    //                    {
    //                        comando.CommandType = CommandType.Text;
    //                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
    //                        MySqlDataReader dr = comando.ExecuteReader();
    //                        if (dr.Read())
    //                        {
    //                            foto = (byte[])dr["Foto"];
    //                        }
    //                    }
    //                }
    //            }
    //            catch (System.Exception ex)
    //            {

    //            }
    //            return foto;
    //        }
    //    }
}
