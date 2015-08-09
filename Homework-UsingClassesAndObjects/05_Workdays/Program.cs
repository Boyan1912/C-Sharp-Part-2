using System;
class Workdays
    {
        static void Main()
        {
            //  Write a method that calculates the number of workdays between today and given date, passed as parameter.
            //  Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

            Console.WriteLine("Please enter a future date (MM/dd/yyyy): ");
            DateTime future = DateTime.Parse(Console.ReadLine());

            int result = CalculateWorkdays(DateTime.Now, future);

            Console.WriteLine("There are, since today {0} up to {1}, {2} workdays", DateTime.Now.ToString("MMMM/dd/yyyy"), future.ToString("MMMM/dd/yyyy"), result);

        }
  
    static int CalculateWorkdays (DateTime today, DateTime futureDate)
        {
            string[] publicHolidays = { "01/01/2015", "01/02/2015", "03/03/2015", "05/01/2015", "05/06/2015",
                                          "05/24/2015", "09/06/2015", "09/22/2015", "10/01/2015", "12/24/2015",
                                            "12/25/2015", "12/26/2015"};

            DateTime[] holidays = new DateTime[publicHolidays.Length];

            for (int i = 0; i < holidays.Length; i++)
            {
                holidays[i] = DateTime.Parse(publicHolidays[i]);
            }
            
            int[,] calendar = new int[6, 7];

            
            int col = 0;
            switch (today.DayOfWeek.ToString())
            {
                case "Monday": col = 0; break;
                case "Tuesday": col = 1; break;
                case "Wednesday": col = 2; break;
                case "Thursday": col = 3; break;
                case "Friday": col = 4; break;
                case "Saturday": col = 5; break;
                case "Sunday": col = 6; break;

            }

            int currentYear = today.Year;
            
            int currentDay = today.Day;
            int countWorkdays = 0;
            int monthCount = today.Month;
            int currentMonthEnd = DetermineMonthEndDay(monthCount, currentYear);
            bool endCount = false;
            
            for (int row = 0; row < calendar.GetLength(0); row++)
            {

                for (col = col; col < calendar.GetLength(1); col++)
                {

                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (monthCount == holidays[i].Month && currentDay == holidays[i].Day && col <= 4)
                        {
                            countWorkdays--;
                        }

                    }

                    calendar[row, col] = currentDay;
                    countWorkdays++;
                    currentDay++;

                    if (col > 4)
                    {
                        countWorkdays--;
                    }
                    if (monthCount == 12 && currentDay == 31 && currentYear < futureDate.Year)
                    {
                        currentYear++;
                        monthCount = 1;
                        currentDay = 1;
                        currentMonthEnd = DetermineMonthEndDay(monthCount, currentYear);
                        row = 0;
                    }

                    if (monthCount >= futureDate.Month && currentDay >= futureDate.Day && currentYear >= futureDate.Year)
                    {
                        endCount = true;
                        continue;
                    }

                    if (currentDay >= currentMonthEnd)
                    {
                        countWorkdays++;
                        currentDay = 1;
                        row = 0;
                        monthCount++;
                        currentMonthEnd = DetermineMonthEndDay(monthCount, currentYear);
                    }
                
                }

                if (endCount)
                {
                    continue;
                }
                col = 0;

            }

            return countWorkdays;
        }
    static int DetermineMonthEndDay (int month, int year)
    {
        int endMonthDay = 0;
        

        if (month == 2 && DateTime.IsLeapYear(year))
        {
            endMonthDay = 29;
        }
        else if (month == 2 && !DateTime.IsLeapYear(year))
        {
            endMonthDay = 28;
        }
        else if (month == 7)
        {
            endMonthDay = 31;
        }
        else if ((month <= 6 && month % 2 != 0) || (month > 7 && month % 2 == 0))
        {
            endMonthDay = 31;
        }
        else if ((month <= 6 && month % 2 == 0) || (month > 7 && month % 2 != 0))
        {
            endMonthDay = 30;
        }

        return endMonthDay;

    }
}

