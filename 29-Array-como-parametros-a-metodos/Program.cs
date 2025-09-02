using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Array_como_parametros_a_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Arreglos como parámetros de métodos
             * 
             * Cuando enviamos un arreglo como parámetro a un método:
             * 
             *  El arreglo enviado y el arreglo del parámetro deben ser el mismo tipo de dato.
             *  
             *  Deben tener las mismas dimensiones, es decir ambos son como lista o como matriz.
             *  
             *  Ambos deben ser el mismo estilo: normal o jagged.
             *  
             *  Definir un método con arreglo:
             *  
             *  static void Imprime(int[] arreglo)
             *  {
             *  
             *     Código
             *     
             *  }
             *  
             *  Invocación:
             *  
             *  int[] numeros = new int[5];
             *  imprime(numeros);
             *  
             *  
             *  
             *  
             *  
             */

            int numero;

            Console.WriteLine("ingrese la cantidad de números que va a ingresar");
            numero = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[numero];

            int n = 0;

            Console.WriteLine("Este programa te solicitará {0} números", numeros.Length);


            for(n = 0; n < numeros.Length; n++)
            {
                Console.WriteLine("Ingresa un número:");
                numeros[n] = Convert.ToInt32(Console.ReadLine());

            }

            Imprimir(numeros);


            Console.ReadKey();
        }


        static void Imprimir(int[] numeros)
        {
            Console.WriteLine("El listado de números contenidos en el array son:");

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("{0}", numeros[i]);
            }
        }
    }
}
