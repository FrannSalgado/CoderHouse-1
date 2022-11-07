using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Salgado
{
    internal class producto
    {
        public int id { get; set; }

        public string descripcion { get; set; }

        public double costo { get; set; }

        public double precioVenta { get; set; }

        public int stock { get; set; }

        public int idUsuario { get; set; }


        public producto() { }

        public producto(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            id = Id;
            descripcion = Descripcion;
            costo = Costo;
            precioVenta = PrecioVenta;
            stock = Stock;
            idUsuario = IdUsuario;
        }
    }
}

