using System;

class SelectionSort
    {
        static void Main()
        {

            // Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            // Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Please enter values in the array: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here is your array sorted:");

            // Array.Sort(array);

            int minPosition = 0;
            int temp = 0;
            
            for (int i = 0; i < n - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minPosition])
                    {
                        minPosition = j;

                    }

                }

                temp = array[minPosition];
                array[minPosition] = array[i];
                array[i] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }

        }
    }

