using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libreria.Model;
using Curso.Libreria.Dao;

namespace Curso.Libreria.Controller
{
    public class LibrosController
    {

        public LibroModel BuscarPorTitulo(string titulo)
        {
            Curso.Libreria.Dao.LibrosDao dao = new Curso.Libreria.Dao.LibrosMySql();
            LibroModel lib = null;
            lib = dao.BuscarPorTitulo(titulo);
            if (lib == null)
            {
                throw new Exception("El libro no se pudo encontrar");
            }
            return lib;
        }
    }
}
