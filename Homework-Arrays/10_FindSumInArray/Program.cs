using System;

class FindSumInArray
    {
        static void Main(string[] args)
        {

            // Write a program that finds in given array of integers a sequence of given sum S (if present).

            Console.WriteLine("Please enter values in the array: ");
            string[] input = Console.ReadLine().Split(' ');
            int s = int.Parse(Console.ReadLine());

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                 numbers[i] = int.Parse(input[i]);
            }

            int startIndex = 0;
            int currentSum = 0;
            int endIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];

                if (currentSum > s)
                {
                    currentSum = 0;
                    i = startIndex;
                    startIndex++;
                }

                if (currentSum == s)
                {
                    endIndex = i;
                    break;
                }

            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0}, ", numbers[i]);

            }
            
            
        }
    }

