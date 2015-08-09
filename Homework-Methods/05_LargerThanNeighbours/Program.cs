using System;
class LargerThanNeighbours
{
        static void Main()
        {
            // Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
            Console.WriteLine("Enter size for the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter values in the array");
            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("What position in the array are you interested in?");
            int searchIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("This number is larger than its neighbours?: {0}", LargerThanNeighbouringElements(searchIndex, numbers));

        }
    
    static bool LargerThanNeighbouringElements (int index, int[] numbers)
        {
            if (index == 0 || index == numbers.Length - 1)
            {
                Console.WriteLine("This number has less than 2 neighbours :(");
                return false;
            }
            else if (index < 0 || index > numbers.Length - 1)
            {
                Console.WriteLine("There is no such index in the array");
                return false;
            }

            else if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
            
    }

}

