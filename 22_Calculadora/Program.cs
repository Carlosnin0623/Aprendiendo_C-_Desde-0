using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  Crea un programa que permita al usuario realizar operaciones matemáticas básicas (suma, resta, multiplicación, división) 
             *  utilizando métodos separados para cada operación. El programa debe solicitar dos números y la operación deseada al usuario 
             *  y luego mostrar el resultado.
             *  
             *  
             *  
             *  Reglas:

                Utiliza la estructura Switch Case

                Usa el Console.ReadKey con la propiedad KeyChar para leer el caracter que el usuario ingrese (símbolos que representan las operaciones matémáticas).
                No utilices Console.RedLine() ya que el programa debe capturar el caracter (char) 
                y no la cadena en la seleción de la operación. Puedes utilizar el siguiente ejemplo:

                Console.Write("Seleccione una operación (+, -, *, /): ");
                ConsoleKeyInfo tecla = Console.ReadKey();
                char operacion = tecla.KeyChar;

                3. El mérodo debe devolver un resultado, significa que no es vacío
             *
             *
             *
             *
             *
             *
             *
             */

            float num1, num2, resultado;

            Console.WriteLine("Esta es una calculadora");
            Console.WriteLine("(+) Suma");
            Console.WriteLine("(-) Resta");
            Console.WriteLine("(*) multiplicación");
            Console.WriteLine("(/) división");


            // ConsoleKeyInfo Esto es para obtener la tecla presionada por el usuario 

            ConsoleKeyInfo tecla = Console.ReadKey();
            char operacion = tecla.KeyChar;
            Console.WriteLine("");

            switch (operacion)
            {
                case '+':

                    Console.WriteLine("Digita el primer número");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digita el segundo número");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    resultado = Suma(num1, num2);

                    Console.WriteLine("El resultado de la suma es {0}", resultado);

                    break;

                case '-':
                 
                    Console.WriteLine("Digita el primer número");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digita el segundo número");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    resultado = Resta(num1, num2);

                    Console.WriteLine("El resultado de la resta es {0}", resultado);

                    break;

                case '*':

                    Console.WriteLine("Digita el primer número");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digita el segundo número");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    resultado = Multiplicacion(num1, num2);

                    Console.WriteLine("El resultado de la multiplicación es {0}", resultado);

                    break;

                case '/':

                    Console.WriteLine("Digita el primer número");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digita el segundo número");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    resultado = Division(num1, num2);

                    Console.WriteLine("El resultado de la división es {0}", resultado);

                    break;
            }

            Console.ReadKey();
        }

        static float Suma(float num1, float num2)
        {
            float resultado = 0.0f;

            resultado = num1 + num2;

            return resultado;
        }

        static float Resta(float num1, float num2)
        {
            float resultado = 0.0f;

            resultado = num1 - num2;

            return resultado;
        }

        static float Multiplicacion(float num1, float num2)
        {
            float resultado = 0.0f;

            resultado = num1 * num2;

            return resultado;
        }

        static float Division(float num1, float num2)
        {
            float resultado = 0.0f;

            resultado = num1 / num2;

            return resultado;
        }

    }
}
