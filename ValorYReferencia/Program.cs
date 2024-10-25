using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorYReferencia
{
    internal class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int NumPuertas { get; set; }

            public Vehiculo(string marca, string modelo, int numPuertas)
            {
                Marca = marca;
                Modelo = modelo;
                NumPuertas = numPuertas;
            }
        }

        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = numero1;
            numero2 = 20;
            Console.WriteLine($"Numero 1: {numero1}\nNumero 2: {numero2}");

            Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla", 4);
            Vehiculo vehiculo2 = vehiculo1;

            vehiculo2.Modelo = "Tacoma";
            vehiculo2.NumPuertas = 2;

            Console.WriteLine("Marca: {0}\nModelo: {1}\nNumPuertas: {2}", vehiculo1.Marca, vehiculo1.Modelo, vehiculo1.NumPuertas);
            Console.WriteLine("Marca: {0}\nModelo: {1}\nNumPuertas: {2}", vehiculo2.Marca, vehiculo2.Modelo, vehiculo2.NumPuertas);


            Console.ReadLine();
        }
    }
}
