using System;
using System.Text;


class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            // Write a program to convert hexadecimal numbers to binary numbers (directly).
            Console.WriteLine("Enter a hexadecimal number: ");
            string input = Console.ReadLine();
            Console.WriteLine("The binary representation of {0} is {1}", input, Converter(input).TrimStart('0'));
        }
    
        static string Converter (string input)
        {
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0': number.Append("0000"); break;
                    case '1': number.Append("0001"); break;
                    case '2': number.Append("0010"); break;
                    case '3': number.Append("0011"); break;
                    case '4': number.Append("0100"); break;
                    case '5': number.Append("0101"); break;
                    case '6': number.Append("0110"); break;
                    case '7': number.Append("0111"); break;
                    case '8': number.Append("1000"); break;
                    case '9': number.Append("1001"); break;
                    case 'A': number.Append("1010"); break;
                    case 'B': number.Append("1011"); break;
                    case 'C': number.Append("1100"); break;
                    case 'D': number.Append("1101"); break;
                    case 'E': number.Append("1110"); break;
                    case 'F': number.Append("1111"); break;
                }
            }
            return number.ToString();
        }
    
    }

