using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _23_CalcularFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 2: Calcular factorial
             
              Crea un programa que calcule el factorial de un número ingresado por el usuario utilizando un método.
              El programa debe solicitar un número entero no negativo al usuario y mostrar el factorial correspondiente.
              Reglas:

              El método secundario debe ser de tipo long

              El método secundario debe declarar una variable de tipo int en los atributos

              Recuerda:  Factorial es multiplicar todos los números enteros positivos que hay entre el número propuesto
              (en este caso el ingresado por el usuario) y el 1 


              Activar System.Numerics

              Si usas .NET Framework 4.0 o superior

              Solo necesitas agregar arriba:

              using System.Numerics;

               Se usa solo si debes devolver un datos grande lo mas exacto posible


              Y asegurarte que en tu proyecto esté referenciado System.Numerics.dll.

              En Visual Studio → Solution Explorer → References → Clic derecho → Add Reference
              → busca System.Numerics y actívalo.

             */


            int Numero;
            BigInteger Resultado;

            try
            {
                Console.WriteLine("Calculadora de Factorial");
                Console.WriteLine("Digita el número");
                Numero = Convert.ToInt32(Console.ReadLine());

                Resultado = CalcularFactorial(Numero);

                Console.WriteLine("El factorial del número {0} es: {1}", Numero, Resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido");
            }catch (OverflowException)
            {
                Console.WriteLine("El número ingresado no es permitido intente con uno más pequeño");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.Message);
            }

            Console.ReadKey();
        }

        static BigInteger CalcularFactorial(int Numero1)
        {
            BigInteger Acumulador = 1;


            for(int Numero = 1; Numero <= Numero1; Numero++)
            {
                Acumulador *= Numero;
            }

            return Acumulador;

        }
    }
}
