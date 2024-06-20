using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public void Agregar(Articulo nuevo)
        {

            AccesoDatos datos=new AccesoDatos();
            datos.setearConsulta("insert into articulo(nombre,categoria,medida,perforacion,color) values (@nombre, @categoria, @medida, @perforacion, @color) ");
            datos.setearParametro("@nombre",nuevo.Nombre);
            datos.setearParametro("@categoria", nuevo.Categoria);
            datos.setearParametro("@medida", nuevo.Medida);
            datos.setearParametro("@perforacion", nuevo.Perforacion);
            datos.setearParametro("@color", nuevo.Color);

            datos.ejecutarAccion();
        }
    }
}
