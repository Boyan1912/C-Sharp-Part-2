using System;


class FormatNumber
    {
        static void Main()
        {
            // Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
            // Format the output aligned right in 15 symbols.

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0, 15:F2}\n{1, 15:X}\n{2, 15:P}\n{3, 15:E}", number, number, number, number, number);


        }
    }

