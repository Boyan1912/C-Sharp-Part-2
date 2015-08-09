using System;

    class CompareCharArrays
    {
        static void Main()
        {
            // Write a program that compares two char arrays lexicographically (letter by letter).

            Console.Write("Please enter the length of the arrays: ");
            int n = int.Parse(Console.ReadLine());

            char[] arrayOne = new char[n];
            char[] arrayTwo = new char[n];

            Console.WriteLine("Please enter the characters in the first array: ");

            for (int i = 0; i < n; i++)
            {

                arrayOne[i] = char.Parse(Console.ReadLine());

            }

            Console.WriteLine("Please enter the characters in the second array: ");

            for (int i = 0; i < n; i++)
            {

                arrayTwo[i] = char.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                bool isLetterArrayOneBefore = arrayOne[i] < arrayTwo[i] ? true : false;

                Console.WriteLine("Is Letter {0} before letter {1} in the English alphabet?: {2}", arrayOne[i], arrayTwo[i], isLetterArrayOneBefore);
            }




        }
    }

