using System;

    class MaximalSequence
    {
        static void Main()
        {
            // Write a program that finds the maximal sequence of equal elements in an array.

            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Please enter values in the array: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            
            }

            int repeatedElement = 0;
            int counter = 0;
            int bestCount = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                }

                else
                {
                    counter = 0;
                }

                if (counter > bestCount)
                {
                    bestCount = counter;
                    repeatedElement = array[i];
                    
                }

            }

            for (int i = 0; i <= bestCount; i++)
            {
                Console.Write("{0}, ", repeatedElement);

            }
        
        }
    }

