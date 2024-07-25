using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_07_2024
{
    internal class Program
    {
        //Crea un programa que utilice un bucle while para contar la cantidad de
        //números pares desde 1 hasta un número ingresado por el usuario.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para determinar el límite");
            int limite = int.Parse(Console.ReadLine());

            int contador = 0;
            int numero = 2;

            while (numero <= limite)
            {
                if (numero %2 == 0)
                {
                    contador++;
                }
                numero++;
            }
            Console.WriteLine($"\nLa cantidad de números pares de 1 a {limite} es: {contador}.");

            Console.ReadKey();
        }
    }
}
