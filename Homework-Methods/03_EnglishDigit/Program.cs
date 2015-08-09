using System;


class EnglishDigit
{
        static void Main()
        {
            // Write a method that returns the last digit of given integer as an English word.

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is {0}", DigitInLetters(input));

        }
    
static string DigitInLetters (int a)
        {
            string word = "";
            int result = a % 10;
            switch (result)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;

            }
            return word;        
        }

}

