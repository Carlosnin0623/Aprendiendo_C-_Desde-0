using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_Bloque_de_ejericios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe un programa que tome un número entero y sume todos sus dígitos.
             */

            int numero;
            string resultado;
            int resultado1 = 0;
            string texto;

            Console.WriteLine("Ingrese el número");
            numero = Convert.ToInt32(Console.ReadLine());

            texto = Convert.ToString(numero);

            foreach(char letra in texto)
            {
               resultado = Convert.ToString(letra);
               resultado1 += Convert.ToInt32(resultado);
            }

            Console.WriteLine("El resultado es {0}", resultado1);

            Console.ReadKey();

        }
    }
}
