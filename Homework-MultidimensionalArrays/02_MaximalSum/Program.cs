using System;


class MaximalSum
    {
        static void Main()
        {
            // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

            // Input
            Console.WriteLine("Please enter the matrix's height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the matrix's width");
            int width = int.Parse(Console.ReadLine());

            int[,] matrix = new int[height, width];

            Console.WriteLine("Enter values in the matrix");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++) 
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Solution
            int currentSum = 0;
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestColl = 0;
            int platformHeight = 3;
            int platformWidth = 3;

            for (int row = 0; row <= height - platformHeight; row++)
            {

                for (int coll = 0; coll <= width - platformWidth; coll++)
                {

                    for (int platformRow = row; platformRow < row + platformHeight; platformRow++)
                    {

                        for (int platformColl = coll; platformColl < coll + platformWidth; platformColl++)
                        {

                            currentSum += matrix[platformRow, platformColl];

                            if (bestSum < currentSum)
                            {

                                bestSum = currentSum;
                                bestRow = row;
                                bestColl = coll;

                            }

                        }
                    }
                }
            }
           // Printing

            Console.WriteLine("The largest sum in the matrix (3 x 3) is at :");

            for (int row = bestRow; row < bestRow + platformHeight; row++)
            {

                for (int coll = bestColl; coll < bestColl + platformWidth; coll++)
                {

                    Console.Write("{0, 3}|", matrix[row, coll]);

                }
                Console.WriteLine();

            }

            Console.WriteLine("The sum is {0}", bestSum);
        }
    }

