using System;

class FillTheMatrix
    {
        static void Main(string[] args)
        {
            // Write a program that fills and prints a matrix of size (n, n) as shown below:

            // Input:
            Console.WriteLine("Enter a number for the volume of the matrix (n * n): ");
            int n = int.Parse(Console.ReadLine());

            // a):
            //  1 	5 	9 	13
            //  2 	6 	10 	14  
            //  3 	7 	11 	15
            //  4 	8 	12 	16

            int[,] matrix = new int[n, n];

            int rowFill = 1;
            
            for (int coll = 0; coll < n; coll++)
            {

                for (int row = 0; row < n; row++)
                {
                    
                    matrix[row, coll] = rowFill;
                    rowFill++;
                }
                
            }
            
            // Printing a):
            Console.WriteLine("a):");

            for (int row = 0; row < n; row++)
            {

                for (int coll = 0; coll < n; coll++)
                {

                    Console.Write("{0, 3}|", matrix[row, coll]);

                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 40));


            // b):
            //  1 	8 	9 	16
            //  2 	7 	10 	15
            //  3 	6 	11 	14
            //  4 	5 	12 	13

            rowFill = 1;
            int reverseRowFill = 0;

            for (int coll = 0; coll < n; coll++)
            {

                for (int row = 0; row < n; row++)
                {

                    if (coll % 2 == 0)
                    {
                        matrix[row, coll] = rowFill;
                        rowFill++;
                        reverseRowFill = rowFill - 1 + n;
                    }
                    else
                    {
                        
                        matrix[row, coll] = reverseRowFill;
                        reverseRowFill--;
                    }
                
                }
                rowFill = reverseRowFill + 1 + n;
            }

            // Printing b):
            Console.WriteLine("b):");

            for (int row = 0; row < n; row++)
            {

                for (int coll = 0; coll < n; coll++)
                {

                    Console.Write("{0, 3}|", matrix[row, coll]);

                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 40));

            // c)

            //  7 	11 	14 	16
            //  4 	8 	12 	15
            //  2 	5 	9 	13
            //  1 	3 	6 	10

            int matrixFill = 1;

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    matrix[row + col, col] = matrixFill++;
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    matrix[row, col + row] = matrixFill++;
                }
            }

            // Printing c):
            Console.WriteLine("c):");

            for (int row = 0; row < n; row++)
            {

                for (int coll = 0; coll < n; coll++)
                {

                    Console.Write("{0, 3}|", matrix[row, coll]);

                }
                Console.WriteLine();
            }


        }
    }

