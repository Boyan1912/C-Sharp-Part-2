using System;

    class MaximalKSum
    {
        static void Main()
        {

            //    Write a program that reads two integer numbers N and K and an array of N elements from the console.
            //    Find in the array those K elements that have maximal sum.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array); // сортира елементите във възходящ ред
            int maxSumKelements = 0;

            for (int i = 0; i < k; i++)
            {
                maxSumKelements += array[n - 1 - i]; // събира последните, т.е. най-голямите, к на брой елемента

            }

            Console.WriteLine(maxSumKelements);

        }
    }

