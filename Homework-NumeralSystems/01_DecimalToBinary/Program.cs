using System;
using System.Collections.Generic;
class DecimalToBinary
    {
        static void Main()
        {
            // Write a program to convert decimal numbers to their binary representation.

            Console.WriteLine("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("The binary representation of {0} is {1}", number, Convert.ToString(number, 2)); // направо изкарва в двоична бройна система
            }
            else
            {
                Console.WriteLine("The binary representation of {0} is {1}", number, PositiveToBinary(number));
            }
        }
   

    static string PositiveToBinary (long number)
        {

            List<byte> binary = new List<byte>();
            long binDigit = 0;
            while (number > 0)
            {
                binDigit = number % 2;
                binary.Add((byte)binDigit);
                number /= 2;
            }
            binary.Reverse();
            string binaryDigit = "";
            for (int i = 0; i < binary.Count; i++)
            {
                binaryDigit += binary[i].ToString();
            }
            return binaryDigit;
        
        }
}

