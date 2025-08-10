using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Break_Continue_GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break Nos detiene el ciclo en 

            int id;

            /*
           for(id = 1; id <= 20; id++)
           {

               if(id == 10)
               {
                   break;
               }

               Console.WriteLine("Este es el número {0}", id);
           }

           */

            /* a instrucción continue sirve para saltar el resto del código 
             * de la iteración actual y pasar directamente a la siguiente vuelta del ciclo 

            
            for (id = 1; id <= 20; id++)
            {

                if (id == 10)
                {
                    continue;
                }

                Console.WriteLine("Este es el número {0}", id);
            }

             */

            /* 
             *  En C#, goto se usa para saltar la ejecución del programa a otra parte del 
             *  código marcada con una etiqueta.
             */

            for (id = 1; id <= 20; id++)
            {

                if (id == 9)
                {
                    goto retirados; // Aqui llamo a la etiqueta
                }

                Console.WriteLine("Este es el número {0}", id);
            }

        retirados: // retirados es la etiqueta
          Console.WriteLine("El afiliado 9 se reporto como retirado");

          Console.ReadKey();
        }
    }
}
