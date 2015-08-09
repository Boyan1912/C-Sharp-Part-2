using System;

class LeapYear
    {
        static void Main()
        {
            //     Write a program that reads a year from the console and checks whether it is a leap one.
            //     Use System.DateTime.

            Console.WriteLine("Enter a year: ");
            
            DateTime date = new DateTime(int.Parse(Console.ReadLine()), 1, 1);

            Console.WriteLine("{0} is a leap year?: {1}", date.ToString("yyyy"), DateTime.IsLeapYear(int.Parse(date.ToString("yyyy"))));

        }
    }

