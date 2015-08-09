using System;
using System.Text;
class ReverseString
    {
        static void Main()
        {
            // Write a program that reads a string, reverses it and prints the result at the console.

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }
            Console.WriteLine("Reversed: {0}", result.ToString());
        }
    }

