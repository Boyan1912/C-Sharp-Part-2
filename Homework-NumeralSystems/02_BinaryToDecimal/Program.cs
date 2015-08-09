using System;
using System.Collections.Generic;

class BinaryToDecimal
    {
        static void Main()
        {
            // Write a program to convert binary numbers to their decimal representation.

            Console.WriteLine("Please enter a 8, 16, 32 or 64 digits binary number: ");

            string input = Console.ReadLine();
            
            bool isNegative = input[0] == '1' ? true : false;

            if (isNegative)
            {
                Console.WriteLine("The decimal representation of {0} is {1}", input, NegativeToDecimal(input));
            }
            else
            {
                Console.WriteLine("The decimal representation of {0} is {1}", input, PositiveToDecimal(input));
            }
            
        
        }
  
        static long NegativeToDecimal (string input)
        {
            long decimNumber = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == '1')
                {
                    decimNumber += 1 * (long)Math.Pow(2, (input.Length - 1) - i); 
                }
            }
            decimNumber = (long)Math.Pow(2, input.Length - 1) - decimNumber;
            return decimNumber * -1;
        }

    static long PositiveToDecimal (string input)
        {
            long decimalNumber = 0;
            long number = long.Parse(input);
            for (int i = 0; i < input.Length; i++)
            {
                long remainder = number % 10;
                decimalNumber += remainder * (long)Math.Pow(2, i);
                number /= 10;
            }
            return decimalNumber;

        }
    
    
}

