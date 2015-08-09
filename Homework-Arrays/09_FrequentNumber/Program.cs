using System;

class FrequentNumber
    {
        static void Main()
        {
            // Write a program that finds the most frequent number in an array.

            string[] input = Console.ReadLine().Split(' ', ',');

            int[] numbers = new int[input.Length];

            int counter = 0;
            int mostCommon = 0;
            int bestCount = 1;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                Console.WriteLine(numbers[i]);

            }

            for (int i = 0; i <input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    
                    }

                    if (bestCount < counter)
                    {
                        bestCount = counter;
                        mostCommon = numbers[i];
                        
                    }
                    
                }
                counter = 0;
                
            }
            Console.WriteLine("{0} ({1} times)", mostCommon, bestCount);
        }
    }

