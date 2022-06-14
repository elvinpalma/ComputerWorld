using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class Producto
    {
        //Constructor que inicializa la propiedad Activo
        public Producto()
        {
            Activo = true;
        }

        //Propiedades de la clase Producto
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
