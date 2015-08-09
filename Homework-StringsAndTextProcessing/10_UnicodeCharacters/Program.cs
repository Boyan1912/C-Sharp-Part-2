using System;

    class UnicodeCharacters
    {
        static void Main()
        {
            // Write a program that converts a string to a sequence of C# Unicode character literals.
            // Use format strings.


            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)text[i]);
            }

        }
    }

