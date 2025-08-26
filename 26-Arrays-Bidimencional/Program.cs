using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Arrays_Bidimencional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Arreglos (Arrays) Bidimencionales
             *  
             *  Permite organizar valores en filas y columnas.
             *  
             *  Conocidos como matrices.
             *  
             *  
             *  Usamos dos indices o posiciones (el de la fila y el de la columna)
             *  
             *   Declaracion de los arreglos bidimencionales
             *   
             *   float[,] tabla = new float[5,3]; declaracion con valores definidos
             *   
             *   float[,] tabla = new float[n,m]; declaracion con variables
             *  
             *  
             * */

            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;

            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Ingrese cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[,] calif = new float[salones, cantidad]; // Salones = Columnas, Cantidad = Filas


            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Este es el salon {0}", n);

                for(m = 0; m < cantidad; m++)
                {
                    Console.WriteLine("Digita la calificacion del estudiante {0}", m);
                    calif[n,m] = Convert.ToSingle(Console.ReadLine());

                }
            }


            // Sumando todo para sacar el promedio

            for (n = 0; n < salones; n++)
            {
             
                for (m = 0; m < cantidad; m++)
                {
                   
                    suma += calif[n,m];

                }
            }

            // Promedio 

            promedio = suma / (cantidad * salones);

            // Calificación Minima

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if(calif[n,m] < minima)
                    {
                        minima = calif[n,m];
                    }
                }
            }

            // Calificación Maxima

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (calif[n, m] > maxima)
                    {
                        maxima = calif[n, m];
                    }
                }
            }

            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mas baja es {0}", minima);
            Console.WriteLine("La calificación mas alta es {0}", maxima);

            Console.ReadKey();
        }
    }
}
