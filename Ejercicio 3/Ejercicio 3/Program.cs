using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = Int32.Parse(Console.ReadLine());
            int valorAbs = Math.Abs(num);
            Double Cuadrado = Math.Pow(num, 2);
            Double Raiz = Math.Sqrt(num);
            Double seno = Math.Sin(num);
            Double coseno = Math.Cos(num);
            //int Entero = Math.Round(num);

            Console.WriteLine(value: "Valor Absoluto: " + valorAbs);
            Console.WriteLine(value: "Cuadrado: " + Cuadrado);
            Console.WriteLine(value: "Raiz Cuadrada: " + Raiz);
            Console.WriteLine(value: "Seno: " + seno);
            Console.WriteLine(value: "Coseno: " + coseno);

            Console.Write("Ingrese un numero: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int max = Math.Max(num1, num2);
            int min = Math.Min(num1, num2);

            Console.WriteLine(value: "Valor Maximo: " + max);
            Console.WriteLine(value: "Valor Minimo: " + min);

            Console.ReadKey();


        }
    }
}
