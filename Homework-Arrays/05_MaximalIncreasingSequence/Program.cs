using System;
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            // Write a program that finds the maximal increasing sequence in an array.

            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Please enter values in the array: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            int counter = 0;
            int bestcount = 0;
            int endSequence = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1] - 1)
                {
                    counter++;
                }

                else
                {
                    counter = 0;
                }

                if (counter > bestcount)
                {
                    bestcount = counter;
                    endSequence = array[i + 1];

                }

            }

            for (int i = endSequence - bestcount; i <= endSequence; i++)
            {
                Console.Write("{0}, ", i);
            }

        }
    }

