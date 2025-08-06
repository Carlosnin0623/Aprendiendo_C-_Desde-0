using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Academia Ciencia";

            foreach (char letra in nombre)
            {
                Console.WriteLine("{0}", letra);
            }

            Console.ReadKey();
        }
    }
}
