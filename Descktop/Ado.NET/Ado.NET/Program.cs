using System;
using MySql.Data.MySqlClient;

namespace Ado.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection Connection = new MySqlConnection("Database=ado;Data Source=localhost;User Id=root;Password=");
            MySqlDataReader DataReader = null;
            MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO libros VALUES('C#', 'Andres', 'ITMA', 'Sin comentarios');", Connection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM libros;", Connection);

            Connection.Open();
            /*
            int n = InsertCommand.ExecuteNonQuery();
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                if (n > 0)
                {
                    Console.WriteLine("Se insertaron {0} datos.", n);
                }
                Connection.Close();
                Connection.Dispose();
            }
             */

            if (Connection.State == System.Data.ConnectionState.Open)
            {
                using (DataReader = SelectCommand.ExecuteReader())
                    while (DataReader.Read())
                    {
                        Console.WriteLine("Titulo: {0}", DataReader["titulo"]);
                        Console.WriteLine("Autor: {0}", DataReader["autor"]);
                        Console.WriteLine("Editorial: {0}", DataReader["editorial"]);
                        Console.WriteLine("Descripcion: {0}", DataReader["descripcion"]);
                        Console.WriteLine("------------------------------------");
                    }
                Connection.Clone();
                Connection.Dispose();

            }
            else
            {
                Console.WriteLine("Fallo la conexion");
            }
            Console.ReadLine();
        }
    }
}
