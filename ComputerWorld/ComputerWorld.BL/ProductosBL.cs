using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Computadora Dell";
            producto1.Precio = 12500;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Computadora HP";
            producto2.Precio = 14000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Computadora Toshiba";
            producto3.Precio = 13500;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
