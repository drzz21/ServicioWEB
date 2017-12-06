using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public string User { get; set; }
        public string Nombre { get; set; }

        private int idd;

        public int MyProperty
        {
            get { return idd; }
            set { idd = value; }
        }


        public Usuario (string _usuario, string _nombre)
        {
            User = _usuario;
            Nombre = _nombre;
        }
    }
}
