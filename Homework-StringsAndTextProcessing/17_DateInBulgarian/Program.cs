using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class DateInBulgarian
    {
        static void Main(string[] args)
        {
            // Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
            // prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

            
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy H:mm:ss", CultureInfo.CreateSpecificCulture("bg-BG"));

            DateTime nextDate = date.AddHours(6.5);

            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("The date after 6 hours and 30 minutes will be {0}", nextDate.ToString("d.MM.yyyy dddd H:mm:ss", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }

