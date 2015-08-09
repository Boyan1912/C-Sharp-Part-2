using System;
using System.Numerics;

class NumberAsArray
    {
        static void Main()
        {
            // Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
            // Each of the numbers that will be added could have up to 10 000 digits.
          
            Console.WriteLine("Enter size for the first array number");
            int n = int.Parse(Console.ReadLine());

            int[] numberOne = new int[n];

            Console.WriteLine("Enter values in the array in reverse order");
            for (int i = 0; i < n; i++)
            {

                numberOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter size for the second array number");
            int m = int.Parse(Console.ReadLine());

            int[] numberTwo = new int[m];

            Console.WriteLine("Enter values in the array in reverse order");
            for (int i = 0; i < m; i++)
            {

                numberTwo[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sum is {0}", SumNumbers(numberOne, numberTwo));

        }
    

        static BigInteger SumNumbers (int[] digitsOne, int[] digitsTwo)
        {
            string numberOne = "";
            string numberTwo = "";
            for (int i = digitsOne.Length - 1; i >= 0; i--)
            {
                numberOne += digitsOne[i].ToString();

            }

            for (int i = digitsTwo.Length - 1; i >= 0; i--)
            {
                numberTwo += digitsTwo[i].ToString();

            }

            BigInteger sum = BigInteger.Parse(numberOne) + BigInteger.Parse(numberTwo);
            return sum;
        }


}

