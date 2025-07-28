using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrucura_Selectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;


            Console.WriteLine("Digite el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            resultado = (num1 + num2) / 2;

            if(resultado > 3.5)
            {
                Console.WriteLine("El alumno ha aprovado el semestre, tu promedio fue {0}", resultado);
            }else
            {
                Console.WriteLine("El alumno ha reprovado el semestre, tu promedio fue {0}", resultado);
            }

            Console.ReadKey();




        }
    }
}
