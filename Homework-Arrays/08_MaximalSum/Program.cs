using System;


class MaximalSum
    {
        static void Main()
        {
            // Write a program that finds the sequence of maximal sum in given array.

            Console.WriteLine("Please enter values in the array: ");
            string[] input = Console.ReadLine().Split(' ');

            int[] array = new int[input.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int startSequence = 0;
            int currentIndex = 0;
            int endSequence = 0;
            int currentSum = array[0];
            int bestSum = 0;
            

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum > 0 )
                {
                    currentSum += array[i];

                }
           
                else
                {
                    currentSum = array[i];
                    currentIndex = i;

                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    endSequence = i;
                    startSequence = currentIndex;

                }

            }
        
            for (int i = startSequence; i <= endSequence; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

        }
    }

