using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Libreria.Dao
{
    public class LibrosMySql : LibrosImp
    {
        protected override string BuscarPorTituloSql()
        {
            return "SELECT * FROM libros WHERE titulo = @titulo";
        }

        protected override string BuscarPorAutorSql()
        {
            throw new NotImplementedException();
        }

        protected override string BuscarPorEditorialSql()
        {
            throw new NotImplementedException();
        }

        protected override string AgregarSql()
        {
            throw new NotImplementedException();
        }

        protected override string EliminarSql()
        {
            throw new NotImplementedException();
        }

        protected override string ActualizarSql()
        {
            throw new NotImplementedException();
        }
    }
}
