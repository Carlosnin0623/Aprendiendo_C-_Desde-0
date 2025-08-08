using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pies, pulgadas, centimetros;
            string resultado;

            try
            {

                do
                {
                    Console.WriteLine("Ingrese los pies");
                    pies = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingrese las pulgadas");
                    pulgadas = Convert.ToSingle(Console.ReadLine());

                    centimetros = ((pies * 12) + pulgadas) * 2.54f;


                    Console.WriteLine("Son {0} centímetros", centimetros);

                    Console.WriteLine("Deseas volver a realizar una converión?");
                    Console.WriteLine("(Si)");
                    Console.WriteLine("(No)");
                    resultado = Console.ReadLine();


                }while(resultado.ToLower() == "si");      
            }
            catch (FormatException)
            {
                    Console.WriteLine("Solo se permiten valores numéricos");
            }
            catch (OverflowException)
            {
                    Console.WriteLine("El número es demasiado grande, intente con 1 más pequeño");
            }

            Console.ReadKey();
              
        }
    }
}
