using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22_07_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bucle While
             *sintaxis
             *
             *
             */
            int n = 0;
            int c = 10;
            bool result = n <= c;
        while (result && c<10)
            {
                Console.WriteLine($"hola mundo {n}");
            }

        Console.ReadKey();
        }
    }
}
