namespace Week6ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algo for transformation 
            // current X axis become the new Y axis
            // Len of the Square Matrix Array - 1 - current Y axis = New X axis

            int[,] matrix1 = { { 1, 2, 3 },
                               { 4, 5, 6 },
                               { 7, 8, 9 }
                             };

            int[,] matrix2 = { {1, 2, 3, 4, 5},
                               {2, 9, 3, 4, 5},
                               {3, 2, 3, 4, 5},
                               {4, 2, 3, 2, 5},
                               {5, 2, 3, 4, 20},
                           };

        }

        static void MatrixRatation(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
    }
}
