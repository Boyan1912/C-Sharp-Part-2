using System;
class SequenceNMatrix
    {
        static void Main()
        {
        //    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
        //    Write a program that finds the longest sequence of equal strings in the matrix.

            Console.WriteLine("Please enter the matrix's height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the matrix's width");
            int width = int.Parse(Console.ReadLine());

            string[,] matrix = new string[height, width];

            Console.WriteLine("Enter values in the matrix");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }


            // Solution

            int counter = 0;
            int bestCount = 0;
            string bestString = "";

            for (int row = 0; row < height; row++)
            {
                for (int coll = 0; coll < width; coll++)
                {
                    int equalRow = row + 1;
                    counter = 0;
                    while (equalRow < height && matrix[row, coll] == matrix[equalRow, coll])
                    {
                        counter++;
                        equalRow++;
                        if (bestCount < counter)
                        {

                            bestCount = counter;
                            bestString = matrix[row, coll];

                        }
                
                    }

                    counter = 0;
                    int equalColl = coll + 1;
                    while (equalColl < width && matrix[row, coll] == matrix[row, equalColl])
                    {
                        counter++;
                        equalColl++;
                        if (bestCount < counter)
                        {

                            bestCount = counter;
                            bestString = matrix[row, coll];

                        }
                    }
                    counter = 0;
                    int equalDiagonalRowRight = row + 1;
                    int equalDiagonalCollRight = coll + 1;
                    while (equalDiagonalRowRight < height && equalDiagonalCollRight < width && matrix[row, coll] == matrix[equalDiagonalRowRight, equalDiagonalCollRight])
                    {
                        counter++;
                        equalDiagonalRowRight++;
                        equalDiagonalCollRight++;
                        if (bestCount < counter)
                        {
                            
                            bestCount = counter;
                            bestString = matrix[row, coll];

                        }
                    }

                    counter = 0;
                    int equalDiagonalRowLeft = row - 1;
                    int equalDiagonalCollLeft = coll - 1;
                    while (equalDiagonalRowLeft > 0 && equalDiagonalCollLeft > 0 && matrix[row, coll] == matrix[equalDiagonalRowLeft, equalDiagonalCollLeft])
                    {
                        counter++;
                        equalDiagonalRowLeft--;
                        equalDiagonalCollLeft--;
                        if (bestCount < counter)
                        {

                            bestCount = counter;
                            bestString = matrix[row, coll];

                        }

                    }
                    
                }

            }

            for (int i = 0; i <= bestCount; i++)
            {

                Console.Write("{0}, ", bestString);

            }
        }
    }

