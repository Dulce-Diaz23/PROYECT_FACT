using Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Datos
{
    public class ProductoDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=diaz;";



        // metodo para manipular usuarios
        public bool Insertar(Producto producto)
        {
            bool inserto = false;
            try                                                   //Capturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("INSERT INTO producto VALUES ");
                sql.Append(" (@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo)");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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
        public bool Editar(Producto producto)           //ERROR
        {
            bool edito = false;
            try                                                   //Capturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("UPDATE  producto SET ");
                sql.Append("  Descrpcion = @Descrpcion, Existencia = @Existencia, Precio = @Precio, Foto=@Foto, EstaActivo = @EstaActivo");
                sql.Append(" WHERE Codigo = @Codigo;");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descrpcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Eliminar(string codigo)
        {
            bool elimino = false;
            try                                                   //Capturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("DELETE FROM producto ");
                sql.Append(" WHERE Codigo = @Codigo;");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
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

        public DataTable DevolverProductos()
        {
            DataTable dt = new DataTable();
            try                                                   //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("SELECT * FROM producto");
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

        public byte[] DevolverFoto(string codigo)
        {
            byte[] foto = new byte[0];

            try                                                   //Capaturar errores, evitar error inesperado
            {
                StringBuilder sql = new StringBuilder();        //genera sentencias de SQL
                sql.Append("SELECT Foto FROM producto WHERE Codigo = @Codigo");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            foto = (byte[])dr["Foto"];
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
            return foto;
        }
    }
}
