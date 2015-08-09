using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            // Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
            // Display them in the standard date format for Canada.

            string text = Console.ReadLine();

            int space = 0;
            int nextSpace = text.IndexOf(' ', 0);
            

            while (nextSpace >= 0)
            {
                // take each word in the text
                string word = text.Substring(space, nextSpace - space).Trim();
                // check if it might be a valid date
                if (char.IsDigit(word[0]))
                {
                    try
                    {
                        DateTime date = DateTime.ParseExact(word, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        Console.WriteLine("{0}", date, CultureInfo.CreateSpecificCulture("ca-CA"));
                    }
                    catch (FormatException)
                    {

                    }
                }
                space = nextSpace;
                nextSpace = text.IndexOf(' ', space + 1);

            }


        }
    }

