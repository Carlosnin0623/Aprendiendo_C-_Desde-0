using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Selectiva_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            try
            {
                Console.WriteLine("Programa que determina el mayor de 3 números");

                Console.WriteLine("Digita el primer número");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digita el segundo número");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digita el tercer número");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                if ((num1 > num2) && (num1 > num3))
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("Este es el mayor {0}", num1);
                        Console.WriteLine("Este es el segundo {0}", num2);
                        Console.WriteLine("Este es el mas pequeño {0}", num3);
                    }
                    else
                    {
                        Console.WriteLine("Este es el mayor {0}", num1);
                        Console.WriteLine("Este es el segundo {0}", num3);
                        Console.WriteLine("Este es el mas pequeño {0}", num2);
                    }

                }
                else if ((num2 > num1) && (num2 > num3))
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("Este es el mayor {0}", num2);
                        Console.WriteLine("Este es el segundo {0}", num1);
                        Console.WriteLine("Este es el mas pequeño {0}", num3);
                    }
                    else
                    {
                        Console.WriteLine("Este es el mayor {0}", num2);
                        Console.WriteLine("Este es el segundo {0}", num3);
                        Console.WriteLine("Este es el mas pequeño {0}", num1);
                    }

                }
                else if ((num3 > num1) && (num3 > num2))
                {
                    if (num1 > num2)
                    {
                        Console.WriteLine("Este es el mayor {0}", num3);
                        Console.WriteLine("Este es el segundo {0}", num1);
                        Console.WriteLine("Este es el mas pequeño {0}", num2);
                    }
                    else
                    {
                        Console.WriteLine("Este es el mayor {0}", num3);
                        Console.WriteLine("Este es el segundo {0}", num2);
                        Console.WriteLine("Este es el mas pequeño {0}", num1);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El tipo de dato introducido no es valido, solo se permiten valores numéricos");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado sobrepasa el límite establecido, intente con otro");

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();

        }
    }
}
