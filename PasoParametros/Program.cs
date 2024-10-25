using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoParametros
{
    internal class Program
    {
        static string ConcatenarSaludo(ref string nombre) // Creamos un método con parametros de referencia
        {
            nombre += " Mundo"; // Modifica la variable pasada por referencia

            return "¡Saludos, " + nombre + "!"; // Devolver un nuevo string
        }

        static void Main(string[] args)
        {
            string cadenaOriginal = "Hola";

            Console.WriteLine("Variable Original sin modificar: {0}", cadenaOriginal);

            string resultado = ConcatenarSaludo(ref cadenaOriginal);

            Console.WriteLine("Variable Original modificada: {0}", cadenaOriginal);
            Console.WriteLine("Resultado Devuelto {0}", resultado);

            Console.ReadLine();
        }
    }
}
