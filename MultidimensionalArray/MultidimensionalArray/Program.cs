using System;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A multidimensional array is an array of arrays. Each element of a multidimensional array is an array itself. 
            int[][] a = new int[3][4]; 
            String[][][] data = new String[3][4][2];

            Here is how we can initialize a 2-dimensional array in C#:
             */
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
            /* or 
             * int[,] arr2d = { 
                    {1, 2}, 
                    {3, 4}, 
                    {5, 6} 
                };
            arr2d[0, 0]; //returns 1
            arr2d[0, 1]; //returns 2
            arr2d[1, 0]; //returns 3
            arr2d[1, 1]; //returns 4
            arr2d[2, 0]; //returns 5
            arr2d[2, 1]; //returns 6
            
             three-dimensional arrays:
            int[, ,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };
             */
            // Printing a 2D array
            long[,] arr = new long[5, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
