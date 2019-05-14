using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Write("1)suma \n2)resta \n3)Multiplicacion \n4)Divicion \nElige el numero de la operacion: ");
                int operacion = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese numero 1: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Ingrese numero 2: ");
                int num2 = Int32.Parse(Console.ReadLine());
                int resultado;
                switch (operacion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.Write(value: num1 + " + " + num2 + " = " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.Write(value: num1 + " - " + num2 + " = " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.Write(value: num1 + " x " + num2 + " = " + resultado);
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.Write(value: num1 + " / " + num2 + " = " + resultado);
                        break;
                }
                Console.Write("\nHacer Otra operacion: \n1)Si \n2)No\n");
                opcion = Int32.Parse(Console.ReadLine());
            }while(opcion != 2);
           

        }
    }
}
