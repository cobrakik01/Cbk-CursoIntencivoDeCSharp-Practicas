using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LibroModel
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
