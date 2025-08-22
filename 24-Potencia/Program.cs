using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Crea un programa que permita al usuario calcular la potencia de un número utilizando un método. 
             * El programa debe solicitar un número base y un exponente, y luego mostrar el resultado.

             Reglas:

             Utiliza números decimales

             El método secundario debe ser de tipo double
             * 
             * 
             * 
             * 
             * 
             */


            float numero, exponente;

            double resultado = 0;

            Console.WriteLine("Digita el número");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digita el exponente");
            exponente = Convert.ToSingle(Console.ReadLine());

            resultado = Potencia(numero, exponente);

            Console.WriteLine("El resultado es {0}", resultado);

            Console.ReadKey();

        }

        static double Potencia(float numero, float exponente)
        {
            double resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado *= numero;
            }

            return resultado;
        }
    }
}
