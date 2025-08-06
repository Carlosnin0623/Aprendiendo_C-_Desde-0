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
            /* Operadores de incrementos y decrementos 
             * 
             *    Operador            Simbolo
             *   Incremento             ++
             *   Decremento             --
             *   
             *   Operador   Ejemplo    Eqivalente A
             *      +=      N+= 5       N = N + 5
             *      -=      N-= 5       N = N - 5
             *      *=      N*= 5       N = N * 5
             *      /=      N/= 5       N = N / 5
             * 
             */

            int n, cantidad;
            float calif;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.WriteLine("Digita la cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for(n = 1; n <= cantidad; n++)
            {
                Console.WriteLine("Digita la calificación del alumno {0}", n);
                calif = Convert.ToSingle(Console.ReadLine());

                suma += calif;
            }

            promedio = suma / cantidad;

            Console.WriteLine("La suma total de calificación es {0}", suma);
            Console.WriteLine("El promedio de la suma es {0}", promedio);



            Console.ReadKey();
        }
    }
}
