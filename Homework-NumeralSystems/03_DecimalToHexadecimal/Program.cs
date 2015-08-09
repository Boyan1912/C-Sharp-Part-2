using System;
using System.Collections.Generic;
class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            // Write a program to convert decimal numbers to their hexadecimal representation.

            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("The hexadecimal representation of {0} is {1}", input, ConvertToHexadecimal(input));

        }
  
        static string ConvertToHexadecimal (int number)
        {
            List<char> hexadecNumber = new List<char>();
            while (number > 0)
            {
                int remainder = number % 16;

                switch (remainder)
                {
                    case 10: hexadecNumber.Add('A'); break;
                    case 11: hexadecNumber.Add('B'); break;
                    case 12: hexadecNumber.Add('C'); break;
                    case 13: hexadecNumber.Add('D'); break;
                    case 14: hexadecNumber.Add('E'); break;
                    case 15: hexadecNumber.Add('F'); break;
                    default: hexadecNumber.Add((char)(remainder + '0')); break;
                }
                number /= 16;
                
            }
            string result = "";
            hexadecNumber.Reverse();
            for (int i = 0; i < hexadecNumber.Count; i++)
            {
                result += hexadecNumber[i].ToString();
            }
            return result;
        }

}

