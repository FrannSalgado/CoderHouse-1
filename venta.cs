using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Salgado
{
    internal class venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }
        public int idUsuario { get; set; }


        public venta() { }

        public venta(int Id, string Comentario, int IdUsuario)
        {
            id = Id;
            comentarios = Comentario;
            idUsuario = IdUsuario;
        }
    }
}
