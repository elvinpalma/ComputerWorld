using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListadeProductos { get; set; }

        //Inicializar en el constructor
        public ProductosBL()
        {
            _contexto = new BL.Contexto();
            ListadeProductos = new List<Producto>();
        }

        //Lista de la base de datos
        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos.ToList();
            return _contexto.Productos.ToList();
        }
    }
}