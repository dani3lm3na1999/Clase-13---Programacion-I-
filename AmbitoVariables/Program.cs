using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbitoVariables
{
    internal class Program
    {
        static int nBase, nExponente, nResultado;

        static void Potencia()
        {
            nResultado = 1;

            for (int i = 0; i < nExponente; i++)
            {
                nResultado *= nBase;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa la base: ");
            nBase = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el exponente: ");
            nExponente = int.Parse(Console.ReadLine());

            Potencia();

            Console.WriteLine("{0} elevado a {1} es igual a {2}", nBase, nExponente, nResultado);

            Console.ReadLine();
        }
    }
}
