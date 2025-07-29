using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_condicional_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operaciones matematicas

            float a, b, resultado;
            int opcion;
            string repetir;

            // Mostrar Menu de opcion
            do
            {
                try
                {
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine("Elige una opción");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el primer número");
                            a = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese el segundo número");
                            b = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            resultado = a + b;
                            Console.WriteLine("El resultado de la suma es: {0}", resultado);
                            break;

                        case 2:
                            Console.WriteLine("Ingrese el primer número");
                            a = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese el segundo número");
                            b = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            resultado = a - b;
                            Console.WriteLine("El resultado de la resta es: {0}", resultado);
                            break;

                        case 3:
                            Console.WriteLine("Ingrese el primer número");
                            a = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese el segundo número");
                            b = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            resultado = a * b;
                            Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
                            break;

                        case 4:
                            Console.WriteLine("Ingrese el primer número");
                            a = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            Console.WriteLine("Ingrese el segundo número");
                            b = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("");

                            resultado = a / b;
                            Console.WriteLine("El resultado de la división es: {0}", resultado);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ocurido un error!, el formato ingresado no es valido");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ha ocurido un error! el valor introducido es superior a lo esperado");

                }catch(Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error {0}", ex.Message);
                }
               
                Console.WriteLine("Desea hacer otra transacción");
                repetir = Console.ReadLine();

            } while (repetir == "Si" || repetir == "si");

            Console.ReadKey();
        }
    }
}
