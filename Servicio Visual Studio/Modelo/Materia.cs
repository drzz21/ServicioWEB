using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Materia
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Materia (int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}
