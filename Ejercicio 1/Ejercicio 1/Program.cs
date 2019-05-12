using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num = Int32.Parse(Console.ReadLine());
            int aux;
            Console.WriteLine("Nuemero Ivertido: ");
            while (num > 0)
            {
                aux = num % 10;
                num = num / 10;
                Console.Write(value: aux);
            }
            Console.ReadKey();
        }
    }
}
