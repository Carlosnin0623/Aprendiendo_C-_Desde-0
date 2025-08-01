using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float calificacion;
            byte asistencia;

            try
            {
                Console.WriteLine("Digite la calificación del estudiante");
                calificacion = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite los días de asistencia del estudiante");
                asistencia = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("");

                if ((calificacion >= 7.0 && calificacion < 10) && (asistencia >= 20) && (asistencia < 30))
                {
                    Console.WriteLine("Haz aprovado de curso");

                }else if (calificacion > 10)
                {
                    Console.WriteLine("Ha ocurrido un error");
                    Console.WriteLine("La puntuación no puede ser mayor a 10", calificacion);

                }else if (asistencia > 30)
                {
                    Console.WriteLine("Ha ocurrido un error");
                    Console.WriteLine("La asistencia no puede ser mayor a 30", asistencia); ;
                }
                else
                {
                    Console.WriteLine("Lo siento, reprobaste el curso");

                }
            }catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error {0}", ex.Message);
            }

            Console.ReadKey();



        }
    }
}
