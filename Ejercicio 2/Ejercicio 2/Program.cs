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

                switch (operacion)
                {
                    case 1:
                        int suma = num1 + num2;
                        Console.Write(value: num1 + " + " + num2 + " = " + suma);
                        break;
                    case 2:
                        int resta = num1 - num2;
                        Console.Write(value: num1 + " - " + num2 + " = " + resta);
                        break;
                    case 3:
                        int mult = num1 * num2;
                        Console.Write(value: num1 + " x " + num2 + " = " + mult);
                        break;
                    case 4:
                        float div = num1 / num2;
                        Console.Write(value: num1 + " / " + num2 + " = " + div);
                        break;
                }
                Console.Write("\nHacer Otra operacion: \n1)Si \n2)No\n");
                opcion = Int32.Parse(Console.ReadLine());
            }while(opcion != 2);
           

        }
    }
}
