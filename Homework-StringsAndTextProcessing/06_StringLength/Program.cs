using System;

class StringLength
    {
        static void Main(string[] args)
        {

            // Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
            // Print the result string into the console.
            Console.WriteLine("Enter text: ");

            string text = Console.ReadLine().PadRight(20, '*');

            Console.WriteLine(text);
        }
    }

