using System;

class SolveTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, 40}", "WELCOME");
            Console.WriteLine("Please select a task: 1) Reverses the digits of a number; 2) Calculates the average of a sequence of integers; 3) Solves a linear equation a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Please enter a number!");
                    long number = long.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("The decimal number should be non-negative");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The reversed number is {0}", ReverseDigits(number));
                        break;
                    }
                case 2: Console.WriteLine("Please enter a sequence of integers divided by space");
                    string[] digits = Console.ReadLine().Split(' ');
                    if (digits.Length < 2)
                    {
                        Console.WriteLine("The sequence should not be empty"); break;
                    }
                    int[] numbers = new int[digits.Length];
                    for (int i = 0; i < digits.Length; i++)
                    {
                        numbers[i] = int.Parse(digits[i]);
                    }
                    Console.WriteLine("The average for these numbers is {0}", Average(numbers)); break;
                case 3: Console.WriteLine("Please enter values for a and b");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine(" a should not be equal to 0 "); break;
                    }
                    else
                    {
                        Console.WriteLine("x = {0}", SolveEquation(a, b)); break;
                    }
                default: Console.WriteLine("Please enter valid values (1 - 3)"); break;
            }

        }
  
    static long ReverseDigits (long number)
        {
            string result = "";
            while (number != 0)
            {
                long remainder = number % 10;
                string reversed = remainder.ToString();
                result += reversed;
                number /= 10;
            }

            number = Convert.ToInt64(result);
            return number;
        }

    static int Average(params int[] numbers)
    {
        int averageSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            averageSum += numbers[i];
        }
        int averageTotal = averageSum / numbers.Length;
        return averageTotal;
    }

    static double SolveEquation(double a, double b)
    {
        double x = 0;
        if (a < 0)
        {
            Console.WriteLine(" a should not be equal to 0 ");

        }
        else
        {
            x = (b * -1) / a;
    
        }
        return x;
    }
}

