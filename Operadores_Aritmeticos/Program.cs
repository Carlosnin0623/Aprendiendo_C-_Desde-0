using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero1, numero2; 
            numero1 = 25;
            numero2 = 30;

            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int multiplicacion = numero1 * numero2;
            int division = numero1 / numero2;

            Console.WriteLine("El resultado de sumar el número {0} y el número {1} es: {2}", numero1, numero2, suma);
            Console.WriteLine("El resultado de restar el número {0} y el número {1} es: {2}", numero1, numero2, resta);
            Console.WriteLine("El resultado de multiplicar el número {0} y el número {1} es: {2}", numero1, numero2, multiplicacion);
            Console.WriteLine("El resultado de dividir el número {0} y el número {1} es: {2}", numero1, numero2, division);
            Console.ReadKey();

        }
    }
}
