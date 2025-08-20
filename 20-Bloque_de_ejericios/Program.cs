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
            float numero;
            float acumulador = 0;
            string respuesta;

            Console.WriteLine("Este programa permite sumar todos los números ingresados");
            Console.WriteLine("hasta que el usuario decida detenerse");

            try
            {
                do
                {
                    Console.WriteLine("Ingrese un número");
                    numero = Convert.ToSingle(Console.ReadLine());

                    acumulador += numero;


                    Console.WriteLine("Desea ingresar otro número");
                    respuesta = Console.ReadLine();


                } while (respuesta.ToLower() == "si");


                Console.WriteLine("El resultado de la suma es: {0}", acumulador);


            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es correcto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado no esta permitido");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.Message);
            }

            Console.ReadLine();
 
        }
    }
}
