using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_Logicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tanque = 40;
            int recorrido = 250;

            if(tanque < 50 && recorrido > 200)
            {
                Console.WriteLine("Las expresiones son verdaderas, tanquear el vehiculo");
            }
            else
            {
                Console.WriteLine("Las expresiones no se cumplen, false");
            }

            Console.ReadKey();
        }
    }
}
