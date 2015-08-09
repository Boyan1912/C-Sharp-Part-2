using System;


class ReverseNumber
    {
        static void Main()
        {
            // Write a method that reverses the digits of given decimal number.


            decimal input = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The number in reverse is:");
            Console.WriteLine(NumberReversal(input));

        }
    
static string NumberReversal (decimal number)
        {
            string result = "";
            while (number != 0)
            {
                ulong remainder = (ulong) number % 10;
                string reversed = remainder.ToString();
                result += reversed;
                number /= 10;
            }

            return result.TrimEnd('0');

        }
}

