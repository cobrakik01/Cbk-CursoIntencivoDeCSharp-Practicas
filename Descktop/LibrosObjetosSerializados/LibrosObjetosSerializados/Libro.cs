using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosObjetosSerializados
{
    [Serializable()]
    public class Libro
    {
        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        private string _Autor;
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        private string _Editorial;
        public string Editorial
        {
            get { return _Editorial; }
            set { _Editorial = value; }
        }

        private string _Prestado;
        public string Prestado
        {
            get { return _Prestado; }
            set { _Prestado = value; }
        }

        public override string ToString()
        {
            return this.Titulo;
        }

    }
}
