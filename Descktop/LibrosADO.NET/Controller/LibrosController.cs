using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Controller
{
    public class LibrosController
    {

        private MySqlConnection conexion;
        private MySqlCommand sqlCommand;
        private MySqlDataReader reader;

        public LibrosController()
            : base()
        {
            conexion = new MySqlConnection("Database=ado;Data Source=localhost;User Id=root;Password=");
            sqlCommand = new MySqlCommand();
            sqlCommand.Connection = conexion;
        }

        public void AgregarLibro(string titulo, string autor, string editorial, string descripcion)
        {
        }

        public void AgregarLibro(LibroModel libro)
        {
        }

        public void EliminarLibro(string titulo)
        {
        }

        public void Actualizar(string tituloOriginal, string titulo, string autor, string editorial, string descripcion)
        {
        }

        public void Actualizar(string tituloOriginal, LibroModel libro)
        {
        }

        public LibroModel ObtenerLibroPorTitulo(string titulo)
        {
            conexion.Open();
            LibroModel libro = null;

            conexion.Dispose();

            return libro;
        }

        public List<LibroModel> ObtenerLibrosPorAutor(string autor)
        {
            List<LibroModel> listaLibros = new List<LibroModel>();
            return listaLibros;
        }

        public List<LibroModel> ObtenerLibrosPorEditorial(string editorial)
        {
            List<LibroModel> listaLibros = new List<LibroModel>();
            return listaLibros;
        }

        public List<LibroModel> ObtenerTodosLosLibros()
        {
            conexion.Open();
            List<LibroModel> listaLibros = new List<LibroModel>();
            sqlCommand.CommandText = "SELECT * FROM libros;";
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                LibroModel libro = new LibroModel();
                libro.Titulo = reader["titulo"].ToString();
                libro.Autor = reader["autor"].ToString();
                libro.Editorial = reader["editorial"].ToString();
                libro.Descripcion = reader["descripcion"].ToString();
                listaLibros.Add(libro);
            }
            conexion.Dispose();
            conexion.Clone();
            return listaLibros;
        }
    }
}
