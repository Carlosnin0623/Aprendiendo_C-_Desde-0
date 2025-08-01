using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Try Catch
             *   
             *   Cuando se presenta un error al momento de ingresar datos, la aplicación
             *   se va a detener. Esta estructura nos va a permitir mostrar el error avisandole
             *   al usuario que ingreso un formato no valido.
             *   
             *   try{
             *      // Codigo
             *   
             *    }catch(Exeption "Tipos de variables de Exepciones) {
             *
             *    } 
             *
             *
             */

            int n1, n2, resultado;

            try
            {
                Console.WriteLine("Ingresa el primer numero");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero");
                n2 = Convert.ToInt32(Console.ReadLine());

                resultado = n1 * n2;

                Console.WriteLine("El resultado es {0}", resultado);
            }catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error {0}", ex.Message);
            }

         

            Console.ReadKey();
        }
    }
}
