using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            float resultado, num1, num2;
            string respusta;

            try
            {
                do
                {
                    Console.WriteLine("Esto es una calculadora");
                    Console.WriteLine("Elige 1 de estas opciones");
                    Console.WriteLine("(1) Sumar");
                    Console.WriteLine("(2) Restar");
                    Console.WriteLine("(3) Multiplicar");
                    Console.WriteLine("(4) Dividir");
                    Console.WriteLine("(5) Salir");
                    opcion = Convert.ToByte(Console.ReadLine());


                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Digite el primer número");
                            num1 = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Digite el segundo número");
                            num2 = Convert.ToSingle(Console.ReadLine());
                            resultado = num1 + num2;
                            Console.WriteLine("El resultado de la suma es: {0}", resultado);
                            break;

                        case 2:
                            Console.WriteLine("Digite el primer número");
                            num1 = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Digite el segundo número");
                            num2 = Convert.ToSingle(Console.ReadLine());
                            resultado = num1 - num2;
                            Console.WriteLine("El resultado de la resta es: {0}", resultado);
                            break;

                        case 3:
                            Console.WriteLine("Digite el primer número");
                            num1 = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Digite el segundo número");
                            num2 = Convert.ToSingle(Console.ReadLine());
                            resultado = num1 * num2;
                            Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
                            break;

                        case 4:
                            Console.WriteLine("Digite el primer número");
                            num1 = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Digite el segundo número");
                            num2 = Convert.ToSingle(Console.ReadLine());
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la división es: {0}", resultado);
                            break;

                        case 5:
                            break;


                        default:
                            Console.WriteLine("La opción seleccionada no es valida");
                            break;

                    }
                    Console.WriteLine("Desea realizar otra operación");
                    Console.WriteLine("(Si)");
                    Console.WriteLine("(No)");
                    respusta = Console.ReadLine();

                } while (respusta.ToLower() == "si");
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado no esta permitido, intente con uno mas pequeño");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.Message);
            }
           
        }
    }
}
