using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ejercicio
{
    internal class Program
    {
        //Escribe un programa que utilice un bucle while para imprimir en la
        //consola una secuencia de números de 10 a 0, de forma decreciente.
        static void Main(string[] args)
        {
            Console.WriteLine("DECRECIENTE DE 10 A 0\n");
            int num = 10;
            int contador = 0;

            while (num >= 0) {
                Console.WriteLine(num);

                if (num % 2 != 0)
                {
                    contador++;
                }
                num--;

            }

            Console.WriteLine($"\nEl numero de impares es: {contador}");
            Console.ReadKey();
        }
    }
}
