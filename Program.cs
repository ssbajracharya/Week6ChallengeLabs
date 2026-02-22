namespace Week6ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix1 = { { 1, 2, 3 },
                               { 4, 5, 6 },
                               { 7, 8, 9 }
                             };

            int[,] matrix2 = { {1, 2, 3, 4, 5},
                               {6, 7, 8, 9, 10},
                               {11, 12, 13, 14, 15},
                               {16, 17, 18, 19, 20},
                               {21, 22, 23, 24, 25},
                           };


            PrintMatrix(matrix1);
            MatrixRotation(matrix1);
            PrintMatrix(matrix1);

            PrintMatrix(matrix2);
            MatrixRotation(matrix2);
            PrintMatrix(matrix2);



        }

        static void MatrixRotation(int[,] matrix)
        {
            int len = matrix.GetLength(0);
            // Transpose Matrix
            for(int i = 0; i < len; i++)
            {
                for(int j = i + 1; j < len; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;

                }
            }


            // Reverse each row
            for (int i = 0; i < len; i++)
            {
                int leftIdx = 0;
                int rightIdx = len - 1;

                while (leftIdx < rightIdx)
                {
                    int temp = matrix[i, leftIdx];
                    matrix[i, leftIdx] = matrix[i, rightIdx];
                    matrix[i, rightIdx] = temp;
                    leftIdx++;
                    rightIdx--;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine(new string('*', 80));
            Console.WriteLine($"\n{matrix.GetLength(0)} by {matrix.GetLength(1)}  matrix printed below: \n");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', 80));

        }
    }
}
