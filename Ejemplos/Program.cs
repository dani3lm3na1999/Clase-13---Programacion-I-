using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        // Método de parámetros por valor
        static void Incrementar(int numero)
        {
            numero++; // Incrementamos el valor en 1

            Console.WriteLine("El valor dentro del método es: {0}", numero);
        }

        // Método de parámetros por referencia
        static void Duplicar(ref int numero)
        {
            numero *= 2;
            Console.WriteLine("El valor dentro del método es: {0}", numero);
        }

        static void Main(string[] args)
        {
            int num = 5;

            //Incrementar(num); // numero = num
            Duplicar(ref num); // se esta pasando la ubicación en memoria de la variable num
            Console.WriteLine("El valor fuera del método: {0}", num);


            Console.ReadLine();
        }
    }
}
