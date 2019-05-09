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
            int num = 501;
            int aux;
        while(num > 0)
           {
               if(num < 1000)
               {
                   aux = num % 10;
                   num = num / 10;
               }
               if(num < 1000)
               {
                   aux = num % 100;
                   num = num / 100;
               }   
                          
           }
                  
    }
}
