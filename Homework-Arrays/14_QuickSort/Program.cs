using System;


class QuickSort
    {
        static void Main(string[] args)
        {
            // Write a program that sorts an array of strings using the Quick sort algorithm.

            string[] stringArray = Console.ReadLine().Split(' ');

            int pivotIndex = stringArray.Length - 1;
            string temp = "";


//      Wikipedia:      
//       Quicksort is a divide and conquer algorithm. Quicksort first divides a large array into two smaller sub-arrays: the low elements and the high elements. Quicksort can then recursively sort the sub-arrays.
//
//The steps are:
//
//    Pick an element, called a pivot, from the array.
//    Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it (equal values can go either way). After this partitioning, the pivot is in its final position. This is called the partition operation.
//    Recursively apply the above steps to the sub-array of elements with smaller values and separately to the sub-array of elements with greater values.


            for (int i = stringArray.Length - 2; i >= 0; i--)
            {

                if (stringArray[i].Length > stringArray[pivotIndex].Length)
                    {
                        temp = stringArray[i];
                        stringArray[i] = stringArray[pivotIndex];
                        stringArray[pivotIndex] = temp;
                        pivotIndex--;
                    }

                    else
                    {
                        pivotIndex--;
                    }

            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("The texts sorted by their respective lengths are: {0}", stringArray[i]);
            }


        }
    }

