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
            string saludo = "Hola mundo!";
            string[] palabra = new string[12];
           
           

            foreach(char letra in saludo)
            {
                Console.WriteLine(letra);
            }

            Console.ReadLine();
 
        }
    }
}
