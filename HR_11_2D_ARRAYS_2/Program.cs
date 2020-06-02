using System;


namespace HR_11_2D_ARRAYS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaro tamaño de filas y columnas
            int filas = 3;
            int columnas = 3;
            // declaro array bidimensional
            int[,] miArray = new int[filas,columnas];

            // Lleno la matriz
            int conteo = 0;

            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++, conteo++)
                {
                    miArray[i, j] = conteo;
                }
            }

            // Muestro matriz/
            for (int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    Console.Write(miArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
