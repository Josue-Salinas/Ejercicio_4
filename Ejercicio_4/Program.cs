using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número maximo:");
            int num_limite = int.Parse(Console.ReadLine());
            Console.WriteLine("========================");
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1: Números pares.");
            Console.WriteLine("2: Números impares.");
            Console.WriteLine("3: Factorial.");
            string opcion = (Console.ReadLine());
            int factorial = 1;
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Números pares: ");
                    for (int i = 2; i <= num_limite; i += 2)
                    {
                        Console.Write(+i + ", ");
                    }

                    break;
                case "2":
                    Console.WriteLine("Números impares: ");
                    for (int i = 1; i <= num_limite; i += 2)
                    {
                        Console.Write(+i + ", ");
                    }
                    break;
                case "3":

                    for (int i = 1; i <= num_limite; i++)
                    {
                        factorial *= i;
                    }
                    Console.Write("El factorial es " + factorial);
                    break;
            }
            Console.ReadKey();
        }
    }
}
