using System;

namespace HR_11_2D_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para arrays en 2 Dimensiones
            //1. Se declara el tamaño de filas y columnas, asi como el array bidimensional
            int rowSize = 2;
            int colSize = 4;
            // tipoArray[,] nombreArray = new tipoArray[filaTamaño,ColumnaTamaño]
            int[,] myArray = new int[rowSize, colSize];

            // Con lo anterior, se crea una matriz de 2x4
            /* La matriz tendría las siguientes coordenadas
             * (0,0)(0,1)(0,2)(0,3)  -> i
             * (1,0)(1,1)(1,2)(1,3)  -> j
             * 
             * Para su elaboración, se pueden usar ciclos anidados
             * For exterior -> filas (rows) de la matriz, corresponden a i
             * For interior -> columnas (columns) de la matriz, corresponden a j
             */

            // 2. Se asigna el valor de count a cada elemento en el array 2d previamente declarado
            int count = 0;

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++, count++)
                {
                    myArray[i, j] = count;
                }
            }

            // 3. Imprimiendo el contenido de cada fila
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write(myArray[i, j] + " "); // se imprime cada columna con espacio
                }
                Console.WriteLine(); // se imprime una linea entre filas
            }


        }
    }
}
