using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libreria.Model;

namespace Curso.Libreria.Dao
{
    public interface LibrosDao
    {
        LibroModel BuscarPorTitulo(string titulo);
        List<LibroModel> BuscarPorAutor(string autor);
        List<LibroModel> BuscarPorEditorial(string autor);

        int Agregar(LibroModel libro);
        int Eliminar(string titulo);
        int Actualizar(string titulo, LibroModel libro);
    }
}
