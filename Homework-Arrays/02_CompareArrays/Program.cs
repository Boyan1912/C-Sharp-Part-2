using System;
    class CompareArrays
    {
        static void Main()
        {
            // Write a program that reads two integer arrays from the console and compares them element by element.

            Console.Write("Please enter the length of the arrays: ");
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];

            Console.WriteLine("Please enter the elements values of the first array: ");

            for (int i = 0; i < n; i++)
            {

                arrayOne[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Please enter the elements values of the second array: ");

            for (int i = 0; i < n; i++)
            {

                arrayTwo[i] = int.Parse(Console.ReadLine());

            }
            
                
            for (int i = 0; i < n; i++)
            {
                bool isArrayOneBigger = arrayOne[i] > arrayTwo[i] ? true : false;

                Console.WriteLine("First array element is bigger than second array's one: {0}", isArrayOneBigger);

            }
      
        
        
        }
    }

