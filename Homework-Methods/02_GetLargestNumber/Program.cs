using System;
class GetLargestNumber
    {
        static void Main(string[] args)
        {
            //    Write a method GetMax() with two parameters that returns the larger of two integers.
            //    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write("The largest number is: ");
            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }
   
    static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    
    }
}

