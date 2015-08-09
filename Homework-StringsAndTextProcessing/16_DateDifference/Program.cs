using System;
using System.Globalization;


class DateDifference
    {
        static void Main(string[] args)
        {
            // Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

            Console.WriteLine("Enter date one: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter date two: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("There are {0} days between the two dates", (secondDate - firstDate).TotalDays);

        }
    }

