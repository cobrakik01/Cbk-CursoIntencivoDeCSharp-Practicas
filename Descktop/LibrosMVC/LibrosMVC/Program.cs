using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libreria.Model;
using Curso.Libreria.Controller;

namespace Curso.Libreria.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibrosController cont = new LibrosController();
            LibroModel lib = cont.BuscarPorTitulo("C#");
            Console.Write(lib.Autor);
            Console.ReadLine();
        }
    }
}
