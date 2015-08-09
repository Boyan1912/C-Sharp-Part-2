using System;
class SortingArray
{
        static void Main()
        {
            // Write a method that return the maximal element in a portion of array of integers starting at given index.
            // Using it write another method that sorts an array in ascending / descending order.

            Console.WriteLine("Enter size for the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter values in the array");
            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the start and end index of the array's portion");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The maximal element in this portion is {0}", numbers[MaxElement(start, end, numbers)]);

            Console.WriteLine("The array sorted in decending order is:");
            SortElements(numbers);
            for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine(numbers[i]);
             }

        }
     static int MaxElement (int start, int end, int[] numbers)
        {
            int maxValue = int.MinValue;
            int bestIndex = 0;
            for (int i = start; i <= end; i++)
            {
                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                    bestIndex = i;
                }

            }

            return bestIndex;
        }
    static void SortElements (int[] numbers)
      {
        for (int i = 0; i < numbers.Length; i++)
        {
            int tempIndex = MaxElement(i, numbers.Length - 1, numbers);
            if (numbers[i] < numbers[tempIndex])
            {
                int temp = numbers[i];
                numbers[i] = numbers[tempIndex];
                numbers[tempIndex] = temp;
            }

        }

      }
}

