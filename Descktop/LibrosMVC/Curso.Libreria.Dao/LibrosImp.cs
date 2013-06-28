using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libreria.Model;
using Curso.Libreria.Util;
using System.Data;

namespace Curso.Libreria.Dao
{
    public abstract class LibrosImp : LibrosDao
    {
        protected abstract string BuscarPorTituloSql();
        public LibroModel BuscarPorTitulo(string titulo)
        {
            IDbCommand command = DataSourceFactory.GetDataSource().GetCommand();
            IDataReader reader = null;
            LibroModel libro = null;

            using (DataSourceFactory.GetDataSource().GetConnection())
            using (command)
            {
                command.CommandText = BuscarPorTituloSql();
                command.Parameters.Add(DataSourceFactory.GetDataSource().GetParameter("@titulo", titulo));

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    libro = new LibroModel();
                    libro.Titulo = reader.GetString(0);
                    libro.Autor = reader.GetString(1);
                    libro.Editorial = reader.GetString(2);
                    libro.Descripcion = reader.GetString(3);
                }
            }
            return libro;
        }

        protected abstract string BuscarPorAutorSql();
        public List<LibroModel> BuscarPorAutor(string autor)
        {
            throw new NotImplementedException();
        }

        protected abstract string BuscarPorEditorialSql();
        public List<LibroModel> BuscarPorEditorial(string autor)
        {
            throw new NotImplementedException();
        }

        protected abstract string AgregarSql();
        public int Agregar(LibroModel libro)
        {
            throw new NotImplementedException();
        }

        protected abstract string EliminarSql();
        public int Eliminar(string titulo)
        {
            throw new NotImplementedException();
        }

        protected abstract string ActualizarSql();
        public int Actualizar(string titulo, LibroModel libro)
        {
            throw new NotImplementedException();
        }
    }
}
