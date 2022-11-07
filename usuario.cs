using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Salgado
{
    internal class usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string mail { get; set; }



        public usuario() { }

        public usuario(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail) {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            nombreUsuario = NombreUsuario;
            contraseña = Contraseña;
            mail = Mail;


        }
       

    }
}
