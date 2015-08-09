using System;


class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size for the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter values in the array");
            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());
            }

            if (FirstLargerElement(numbers) >= 0)
            {
                Console.WriteLine("The first element larger than its neighbours is {0}", numbers[FirstLargerElement(numbers)]);

            }

            else
            {
                Console.WriteLine("No element in the array is larger than its neighbours");
            }

        }
        static int FirstLargerElement (int[] numbers)
        {
            for (int index = 1; index < numbers.Length - 1; index++)
            {

                if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                {
                    return index;
                }
              
            }

            return -1;
        }           
}

