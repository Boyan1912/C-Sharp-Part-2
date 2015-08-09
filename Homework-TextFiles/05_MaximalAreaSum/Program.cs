using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalAreaSum
    {
        static void Main(string[] args)
        {/*
    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.*/

            int maxSum = 0;

            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                int N = int.Parse(reader.ReadLine());

                int[,] matrix = new int[N, N];

                // fill the matrix
                for (int i = 0; i < N; i++)
                {
                    string[] lineNumbers = reader.ReadLine().Split(' ');
                    
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = int.Parse(lineNumbers[j]);
                        
                    }
                    
                }
                maxSum = FindMaxSum(matrix);
            }
            // create new file with the result in it
            File.AppendAllText(@"..\..\output.txt", maxSum.ToString());

        }
    static int FindMaxSum (int[,] matrix)
        {
            int platformHeight = 2;
            int platformWidth = 2;
            int sum = 0;
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    for (int i = 0; i <= matrix.GetLength(0) - platformHeight; i++)
                    {

                        for (int j = 0; j <= matrix.GetLength(1) - platformWidth; j++)
                        {
                            sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                            if (bestSum < sum)
                            {
                                bestSum = sum;
                            }
                        }
                        
                    }
                    
                }
            }
            return bestSum;
        }

}

