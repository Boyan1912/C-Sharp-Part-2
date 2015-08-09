using System;
using System.Text;
class OneSystemToAnyOther
    {
        // Write a program to convert from any numeral system of given base s to any other numeral system of base d.
        static void Main()
        {
            Console.WriteLine("Please enter the base of the numeral system you want to convert from: ");
            int numeralBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number (numeral system base: {0}):", numeralBase);
            string number = Console.ReadLine();
            Console.WriteLine("Enter the base of the numeral system you want to convert to: ");
            int conversionBase = int.Parse(Console.ReadLine());

            long numberInDecimal = ConvertToDecimal(number, numeralBase);
            string result = ConvertFromDecimal(numberInDecimal, conversionBase);
            Console.WriteLine("Your number converted to numeral system with base {0} is {1}", conversionBase, result);
        }
  

    static long ConvertToDecimal (string input, int numeralBase)
        {

            long decimalNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                
                if (char.IsDigit(input[i]))
                {
                    decimalNumber += (input[i] - '0') * (long)Math.Pow(numeralBase, input.Length - 1 - i); 
                }
                else if (char.IsLetter(input[i]))
                {
                    decimalNumber += (input[i] - 'A' + 10) * (long)Math.Pow(numeralBase, input.Length - 1 - i); // Ako e над десетична бройна с-ма превръща буквите в числа (от ASCII таблицата)
                }
            }

            return decimalNumber;
        }

    static string ConvertFromDecimal (long input, int conversionBase)
    {
        StringBuilder number = new StringBuilder();

        while (input > 0)
        {
            long remainder = input % conversionBase;

            if (remainder < 10)
            {
                number.Insert(0, remainder);
            }
            else
            {
                remainder += 'A' - 10;          // превръща числата над 9 в букви (От ASCII таблицата) 
                number.Insert(0, (char)remainder); // полученото число го вкарваме като char
            }
            input /= conversionBase;
        }

        return number.ToString();
    }
}

