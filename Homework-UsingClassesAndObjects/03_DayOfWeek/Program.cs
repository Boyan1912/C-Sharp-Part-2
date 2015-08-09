using System;

class DayOfWeek
    {
        static void Main()
        {
            //Write a program that prints to the console which day of the week is today.
            //Use System.DateTime.

            DateTime today = DateTime.Now;

            Console.WriteLine("Today is {0}", today.ToString("dddd"));

        }
    }

