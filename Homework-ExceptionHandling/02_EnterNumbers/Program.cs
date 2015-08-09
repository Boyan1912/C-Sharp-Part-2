using System;

class EnterNumbers
    {
        static void Main(string[] args)
        {
            // Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
            // If an invalid number or non-number text is entered, the method should throw an exception.
            // Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

            int a = 1;
            int b = 100;
            ReadNumber(a, b);

        }
  
    static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        Console.WriteLine("Number is within specified range");
                    }
                
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Entered value was not a number or an integer!");
                }

            }

        }



}

