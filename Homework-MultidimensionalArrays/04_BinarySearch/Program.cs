using System;


    class BinarySearch
    {
        static void Main()
        {
            // Write a program, that reads from the console an array of N integers and an integer K, sorts the array and 
            // using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
            
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(numbers);
            int index = Array.BinarySearch(numbers, k);

            // Wikipedia: If array does not contain the specified value, the method returns a negative integer. 
            // You can apply the bitwise complement operator (~ in C#, Not in Visual Basic) to the negative result to produce an index. 
            // If this index is equal to the size of the array, there are no elements larger than value in the array. 
            // Otherwise, it is the index of the first element that is larger than value. 

            if (index < 0)
            {
                index = ~index;

                if (index == numbers.Length)
                {
                    index = numbers.Length - 1;

                }

                else
                {
                    index --;
                }

            }

            Console.WriteLine("The largest number in the array which is ≤ K is: {0}", numbers[index]);
        
        }
    }

