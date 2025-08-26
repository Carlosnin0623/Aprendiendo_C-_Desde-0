using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Ejercicio_Array_Bidimencional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion Array Bidimencional ejercicio - Matriz
            int[,] matriz = {
                            {1,2,3},
                            {4,5,6},
                            {7,8,9}
                            };

            int suma = 0;

            for(int i = 0; i < matriz.GetLength(0); i++) // matriz.GetLength(0): Obtiene el número de columnas
            {
                for(int j = 0; j < matriz.GetLength(1); j++) // // matriz.GetLength(1): Obtiene el número de filas
                {
                    suma += matriz[i,j];
                }
            }

            Console.WriteLine("La suma de los valores de la matriz es: {0}", suma);

            Console.ReadKey();
        }
    }
}
