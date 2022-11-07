using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Salgado
{
    internal class productoVendido
    {
        public int id { get; set; }

        public int idProducto { get; set; }

        public int stock { get; set; }

        public int idVenta { get; set; }

        public productoVendido() { }

        public productoVendido(int Id, int IdProducto, int Stock, int IdVenta)
        {
            id = Id;
            idProducto = IdProducto;
            stock = Stock;
            idVenta = IdVenta;
        }
    }
}
