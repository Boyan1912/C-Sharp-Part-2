using System;


class SquareRoot
    {
        static void Main()
        {   /*
            Write a program that reads an integer number and calculates and prints its square root.
            If the number is invalid or negative, print Invalid number.
            In all cases finally print Good bye.
            Use try-catch-finally block.
    */
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);
                if (number < 0)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    Console.WriteLine("Square root from {0} is {1}", number, Math.Sqrt(number));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number! Number was not in the correct format. Please enter a valid value!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Number must be a non-negative value");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }

