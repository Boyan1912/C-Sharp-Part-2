using System;

class SubStringInText
    {
        static void Main(string[] args)
        {
            //     Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

            Console.WriteLine("Enter text:");
            string text = Console.ReadLine().ToLower();  // ToLower() to perform case insensitive search
            Console.WriteLine("Enter search term:");
            string searchString = Console.ReadLine();
            
            int minIndex = text.IndexOf(searchString, 0);
            int count = 0;
            while (minIndex >= 0)
            {

                minIndex = text.IndexOf(searchString, minIndex + searchString.Length);
                count++;
            }
        
        Console.WriteLine("{0} is found {1} times in the rext", searchString, count);
        }
    }

