using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Funciones_y_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * La función o metodo es un elemento del programa que contiene codigo
             * y se puede ejecutar, es decir, llevar a cabo una operacion (Conjunto de intrucciones)
             * . La función o metodo puede llamarse o invocarse cuando sea necesario y entonces
             * el codigo que se encuetra en su interior se va a ejecutar. Una vez la función o 
             * metodo termina el programa continua con la sentencia siguiente de donde fue
             * llamada la función.
             * 
             * 
             * Las funciones o metodos constan de cinco partes:
             * 
             * Modificador tipo Nombre (Parametros){
             * 
             *      // Codigo
             *      
             * }
             * 
             * Pueden regresar cadenas, flotantes, enteros, etc
             * 
             * 
             * Tipos de metodos
             * 
             * 1 - Los que ejecutan solo codigo
             * 2 - Los que reciben parametros
             * 3 - Los que regresan valores
             * 4 - Los que reciben valores y parametros
             */

            int opcion; // Variable Global

            Console.WriteLine("1. suma");
            Console.WriteLine("2. resta");
            Console.WriteLine("3. multiplicación");
            Console.WriteLine("4. division");
            Console.WriteLine("Escoge una opción");
            opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1)
            {
                Suma();
            }
            if (opcion == 2)
            {
                float resultado = 0f;

                resultado = Resta();

                Console.WriteLine("El resultado de la resta es: {0}", resultado);
            }
            if (opcion == 3)
            {

            }
            if (opcion == 4)
            {

            }



            Console.ReadKey();

        }


        static void Suma() // 1 - Los que ejecutan solo codigo
        {
            float a, b;  // Variables locales
            float r = 0f;
            
            Console.WriteLine("Ingrese el primero número");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            b = Convert.ToSingle(Console.ReadLine());
            r = a + b;
            Console.WriteLine("El resultado es: {0}", r);

        }

        static float Resta() // 3 - Los que regresan valores
        {
            float a, b;  // Variables locales
            float r = 0f;

            Console.WriteLine("Ingrese el primero número");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            b = Convert.ToSingle(Console.ReadLine());
            r = a - b;
          
            return r; // Con la función return devolvermos el valor

        }
    }
}
