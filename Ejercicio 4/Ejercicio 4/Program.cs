using System;
using System.Linq;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string cad = Console.ReadLine();
            
            Console.Write("Ingrese una letra Para buscar: ");
            string letra = Console.ReadLine();

            if (cad.Contains(letra))
            {
                Console.WriteLine("La frase contiene la letra: " + letra);
            }
            else
            {
                Console.WriteLine("Letra no encontrada");
            }

            Console.WriteLine("Longitud de la cadena = " + cad.LongCount());
            Console.Write("Escriba una frase: ");
            string cad2 = Console.ReadLine();
            string unirCad = cad + " " + cad2;
            Console.WriteLine(unirCad);

            Console.WriteLine("\nElija el incio y cantidad de caracteres de la subcadena:");
            Console.Write("Inicio: ");
            int inicio = Int32.Parse(Console.ReadLine());
            Console.Write("Cantidad de caracteres: ");
            int final = Int32.Parse(Console.ReadLine());

            string subCad = cad.Substring(inicio,final);
            Console.WriteLine(subCad);

            int opcion;
            do
            {
                Console.Write("1)suma \n2)resta \n3)Multiplicacion \n4)Divicion \nElige el numero de la operacion: ");
                int operacion = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese numero 1: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese numero 2: ");
                int num2 = Int32.Parse(Console.ReadLine());
                float resultado;
                switch (operacion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.Write(num1 + " + " + num2 + " = " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.Write(num1 + " - " + num2 + " = " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.Write(num1 + " x " + num2 + " = " + resultado);
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.Write(num1 + " / " + num2 + " = " + resultado);
                        break;
                }

                Console.Write("\nHacer Otra operacion: \n1)Si \n2)No\n");
                opcion = Int32.Parse(Console.ReadLine());
            } while (opcion != 2);
            Console.ReadKey();
        }
    }
}
