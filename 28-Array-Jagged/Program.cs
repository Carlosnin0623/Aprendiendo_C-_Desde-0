using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Array_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Arreglos (Jagged) contenedor
             * 
             * Declaramos arreglo contenedor
             * 
             * int[][] Costos = new int [3][];
             * 
             * Declaramos los arreglossssssssssss 
             * 
             *   Costos[0] = new int[15];
             *   Costos[1] = new int[20];
             *   Costos[2] = new int[10];
             *   
             *   // Esta declaracion es cuando sabemos los valores que va a tener el jagged o arreglo de arreglos
             *   
             *   int[][] valores = new int[3][];
             *   
             *   valores[0] = new int[]{9,3,1,7,2,4};
             *   valores[1] = new int[]{2,9};
             *   valores[2] = new int[]{3,5,2,9};
             *   
             *   /* Esto es cuando no sabes el numero de columnas que va a tener tu jagged y quieres hacer una prueba
             *   
             *   int[][] valores = new int[][] 
             *   
             *   { 
             *       new int[] {9,3,1,7,2,4},
             *       new int[] {2,9},
             *       new int[] {3,5,2,9}
             *  
             *   };
             *   
             *   
             *   // Acceder a un arreglo jagged
             *   
             *   Para acceder a los elementos guardados adentro de un arreglo jagged también necesitamos utilizar
             *   indices. Un índice sera aplicado para indicar cual elemento del arreglo contenedor utilizaremos,
             *   es decir el número de columna. El otro índice nos indicará el elemento del arreglo interno 
             *   que queremos acceder.
             *   
             *      productos[6][7] = 5.7f;
             */

            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;


            Console.WriteLine("Ingrese la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());


            // Declarar la cantidad de salones para el arreglo jagged

            float[][] calif = new float [salones][];

            for(n = 0;  n < salones; n++)
            {
                Console.WriteLine("Ingrese la cantidad de alumnos para el salon {0}", n);
                cantidad = Convert.ToInt32(Console.ReadLine());

                calif[n] = new float[cantidad];
            }

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for(m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("Ingrese calificación");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }

            Console.WriteLine("INFORMACION");

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for(m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
            }

            // Sacar Promedio

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    suma += calif[n][m];
                }
            }

            promedio = suma / (salones * cantidad);

            // Sacar calificación minima

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (calif[n][m] < minima)
                    {
                        minima = calif[n][m];
                    }
                }
            }

            // Sacar calificación maxima

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (calif[n][m] > maxima)
                    {
                        maxima = calif[n][m];
                    }
                }
            }

            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación minima es: {0}", minima);
            Console.WriteLine("La calificación maxima es: {0}", maxima);

            Console.ReadKey();
        }
    }
}
