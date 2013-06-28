using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo15
{
    class Libro
    {
        public string Titulo
        {
            set;
            get;
        }

        public string Autor
        {
            set;
            get;
        }

        public string Editorial
        {
            set;
            get;
        }

        public string Descripcion
        {
            set;
            get;
        }

        public override string ToString()
        {
            return this.Titulo;
        }
    }
}
