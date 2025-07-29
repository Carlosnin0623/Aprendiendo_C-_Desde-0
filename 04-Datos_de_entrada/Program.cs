using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_de_entrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir datos al usuario
            try
            {
                string nombre;
                byte edad;
                float altura;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine(); // Console.ReadLine() Permite que el usuario ingrese datos al sistema
                Console.WriteLine("Ingresa tu edad");
                edad = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Ingresa tu altura");
                altura = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("El nombre ingresado es {0} y su edad es {1} y mi altura es {2}", nombre, edad, altura);
               
            }catch (FormatException)
            {
                Console.WriteLine("El tipo de dato ingresado no es correcto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado es menor o mayor al limite permitido");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error {0}", ex.Message);
            }

            Console.ReadKey();

        }
    }
}
