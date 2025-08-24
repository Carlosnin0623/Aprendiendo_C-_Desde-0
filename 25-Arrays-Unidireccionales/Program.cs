using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Arrays_Unidireccionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *   Arreglos (Arrays)
             *   
             *   Un array es un indicador que puede almacenar varios valores simultaneamente. Cada uno de estos
             *   valores se identifica mediante un número al cual se llama indice. Así, para acceder al primer
             *   elemento del array habria que usar el indice cero, para el segundo indice uno, para el tercer
             *   indice dos, y asi sucesivamente.
             *   
             *   Tipos de Arreglos
             *   
             *   Arreglos de una dimension
             *   
             *   Declaracion:
             *   
             *   tipo[] nombre = new tipo[tamaño];
             *   
             *   Ejemplo de calificaciones
             *   
             *   Instanciacion: Proceso de leer o especificar información, como los valores y el tipo de
             *   almacenamiento de un campo de datos;
             *   
             *   float[] calificaciones = new float[10];
             *   
             *   Asignar valores a un arreglo
             *   
             *   calificaciones[indice] = 8.5f;
             *   calificaciones[2] = 8.5f;
             *   
             *   float[] valores = {1.5f, 3.78f, 2.1f};
             *   
             *
             *   Arreglos de dos dimensiones
             *   
             *   Arreglos de tipo jagged (Un arreglo es arreglo de arreglos)
             *   
             *   Arreglos como parametros a metodos
             *   
             */


            int cantidad;
            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Ingresa cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] calif = new float[cantidad];

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la calificación");
                calif[i] = Convert.ToSingle(Console.ReadLine());
            }

            // Sacar el promedio de las calificaciones

            for(int i = 0; i < cantidad; ++i)
            {
                suma += calif[i];
            }

            promedio = suma / cantidad;


            // Sacar la calificacion minima

            for(int i = 0; i < cantidad; i++)
            {
                if (calif[i] < minima)
                {
                    minima = calif[i];
                }
            }

            // Sacar la calificacion maxima

            for (int i = 0; i < cantidad; i++)
            {
                if (calif[i] > maxima)
                {
                    maxima = calif[i];
                }
            }


        }
    }
}
