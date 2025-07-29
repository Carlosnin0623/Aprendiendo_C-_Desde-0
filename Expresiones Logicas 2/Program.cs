using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_Logicas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1

            bool lluvia = true;
            bool sol = false;

            if((lluvia == true) || (sol == false))
            {
                Console.WriteLine("Debes usar una sombrilla");

            }

            // Ejemplo 2 usando el operador de negacion

            bool dia = true;

            if(!dia == false)  // !dia es igual a dia == false
            {
                Console.WriteLine("No encender la luz");
            }else
            {
                Console.WriteLine("Encender la luz");
             }

            // Ejemplo 3 usando el operador != distinto

            bool dia2 = true;

            if (dia2 != false)  // !dia es igual a dia == false
            {
                Console.WriteLine("No encender la luz");
            }
            else
            {
                Console.WriteLine("Encender la luz");
            }

            /* Programa que determine si el usuario puede conducir  */

            int edad;
            bool permiso;
            string valor;

            Console.WriteLine("Digita tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Tiene permiso de sus padres true = si false = no");
            valor = Console.ReadLine();
            if(valor == "Si" || valor == "si")
            {
                valor = "true";

            }else if (valor == "No" || valor == "no")
            {
                valor = "false";
            }
            permiso = Convert.ToBoolean(valor);

            // Verificar los datos

            if((edad > 18) || (edad > 15 && permiso == true))
            {
                Console.WriteLine("Puede conducir");
            }
            else
            {
                Console.WriteLine("No puede conducir");
            }

                Console.ReadKey();
        }
    }
}
