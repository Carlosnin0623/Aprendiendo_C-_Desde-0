using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  Ciclo For
             *  
             *  Pasos numerados
             *    
             *            1               2         4
             *  For (Inicializacion; condición; incremento)
             *          3
             *       Codigo
             *  
             *  
             *  
             */

            int n = 0;
            int m;

            Console.WriteLine("Ingrese un numero");

            n = Convert.ToInt32(Console.ReadLine());

            for(m = n; n <= 10;  n++)
            {
                Console.WriteLine("{0}", n);
            }

            Console.ReadKey();


            

        }
    }
}
