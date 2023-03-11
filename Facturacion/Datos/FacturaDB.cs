using Entidades;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=diaz;";

        public bool Guardar(Factura factura, List<DetalleFactura> detalles)
        {
            bool inserto = false;
            int idFactura = 0;
            try
            {
                StringBuilder sqlFactura = new StringBuilder(); // ayuda a colocar setencia sql en varias lineas
                sqlFactura.Append("INSERT INTO factura VALUES(@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total);");
                sqlFactura.Append("SELECT LAST_INSERT_ID();"); //Devuelve la ultima llave primaria(id) que se inserta

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append("INSERT INTO detallefactura VALUES_(@IdFactura, @CodigoProducto,@Precio, @Cantidad, @Total);");

                StringBuilder sqlExistencia = new StringBuilder();
                sqlExistencia.Append("UPDATE producto SET Existencia = Existencia - @Cantidad WHERE Codigo = @Codigo;"); //Actualizar, rebajando la cantidad de la existencia
            }
            catch (System.Exception)
            {

                throw;
            }
            return inserto;
        }


    }
}
