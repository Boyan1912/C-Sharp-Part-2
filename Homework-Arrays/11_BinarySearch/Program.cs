using System;
class BinarySearch
    {
        static void Main()
        {
            // Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


            Console.WriteLine("Please enter values in the array: ");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("Please enter the value you are searching for: ");
            int x = int.Parse(Console.ReadLine());

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            Array.Sort(numbers);

            int middle = 0;
            int leftArea = 0;
            int rightArea = numbers.Length;

            while (true)
            {

                middle = (leftArea + rightArea) / 2;

                if (x < numbers[middle])
                {
                    rightArea = middle;

                }

                else if (x > numbers[middle])
                {
                    leftArea = middle;

                }

                else if (x == numbers[middle])
                {
                    Console.WriteLine("Your number is in position {0} in a sorted array", middle);
                    break;
                }
        
                if (middle == leftArea && (middle == rightArea || middle == rightArea - 1) && x != numbers[middle])
                {
                    Console.WriteLine("This number is not in the array!");
                    break;
                }
            
            }


          
        }
    }

