using System;

class AppearanceCount
{
        static void Main()
        {
            // Write a method that counts how many times given number appears in given array.
            // Write a test program to check if the method is workings correctly.

            Console.WriteLine("Enter size for the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter values in the array");
            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("What number are you searching for?");
            int searchNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("This number appears {0} times in the array", Frequency(searchNumber, numbers));

        }
    
    static int Frequency (int a, int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number == a)
                {
                    count++;
                }

            }
            return count;

        }


}

