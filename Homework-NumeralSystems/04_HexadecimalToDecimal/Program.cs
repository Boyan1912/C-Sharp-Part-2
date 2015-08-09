using System;
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            //     Write a program to convert hexadecimal numbers to their decimal representation.

            Console.WriteLine("Enter a hexadecimal number: ");
            string input = Console.ReadLine();
            Console.WriteLine("The decimal representation of {0} is {1}", input, ConvertToDecimal(input));

        }
    
    static int ConvertToDecimal(string hexadecimal)
        {
            int result = 0;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                switch (hexadecimal[i])
                {
                    case 'A': result += 10 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    case 'B': result += 11 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    case 'C': result += 12 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    case 'D': result += 13 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    case 'E': result += 14 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    case 'F': result += 15 * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                    default: result += (hexadecimal[i] - '0') * (int)Math.Pow(16, hexadecimal.Length - 1 - i); break;
                }
            }
            return result;
        }
    
    }

