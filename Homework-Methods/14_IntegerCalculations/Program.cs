using System;
using System.Numerics;

class IntegerCalculations
    {
        static void Main(string[] args)
        {
            // Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
            // Use variable number of arguments.

            char[] array = "this is a char array".ToCharArray();
            int[] randomnNumbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                randomnNumbers[i] = array[i];
            }
            Console.WriteLine(MinimumNumber(randomnNumbers));
            Console.WriteLine(MaximumNumber(randomnNumbers));
            Console.WriteLine(Average(randomnNumbers));
            Console.WriteLine(Sum(randomnNumbers));
            Console.WriteLine(Product(randomnNumbers));
        
        }
    
    static int MinimumNumber (params int[] numbers)
        {
            int minNumber = int.MaxValue;
            foreach (int number in numbers)
            {
                if (minNumber > number)
                {
                    minNumber = number;
                }
            }
            return minNumber;
        }
    static int MaximumNumber (params int[] numbers)
    {
        int maxNumber = int.MinValue;
        foreach (int number in numbers)
        {
            if (maxNumber < number)
            {
                maxNumber = number;
            }
        }
        return maxNumber;
    }

    static int Average (params int[] numbers)
    {
        int averageSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            averageSum += numbers[i];
        }
        int averageTotal = averageSum / numbers.Length;
        return averageTotal;
    }

    static int Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            sum += numbers[i];
        }
        return sum;
    }

    static BigInteger Product(params int[] numbers)
    {
        BigInteger product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {

            product *= numbers[i];
        }
        return product;
    }

}



