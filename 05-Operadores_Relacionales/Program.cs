using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Relacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operadores Relacionales
             * 
             * Se usan para expresar la relacion que existe entre 2 valores
             * 
             * Estas expresiones, al igual que las expresiones aritmeticas, tienen sus propios
             * operadores.
             * 
             * La expresion sera evaluada, pero el resultado de la evaluacion tendra
             * unicamente dos valores posibles: true o false Booleanos
             * 
             * Signo Operador
             * 
             * == igualdad
             * != No igual o distinto
             * > mayor que
             * < menor que
             * >= mayor o  igual que
             * <= menor o igual que
             */
            double nota1, nota2, resultado;

            Console.WriteLine("Escribe el primer número");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Escribe la segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            resultado = (nota1 + nota2) / 2;

            if(resultado <= 5)
            {
                Console.WriteLine("Aprobo el semestre");
            }
            else
            {
                Console.WriteLine("Reprobo el semestre");
            }

            Console.ReadKey();
        }
    }
}
