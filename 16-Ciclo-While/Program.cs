using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int temperatura;

            Console.WriteLine("Ingrese la tempertura actual");
            temperatura = Convert.ToInt32(Console.ReadLine());

            while(temperatura > 0)
            {
              
                Console.WriteLine("La temperatura actual es: {0}", temperatura);
                temperatura--;
                Thread.Sleep(1000);

            }

            Console.WriteLine("Temperatura final {0}", temperatura);


            Console.ReadKey();

        }
    }
}
