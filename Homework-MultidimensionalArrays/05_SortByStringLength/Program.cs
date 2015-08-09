using System;

class SortByStringLength
    {
        static void Main()
        {
            // You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

            string[] array = Console.ReadLine().Split(' ');

            SortByLength(array);

            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);

            }
        }
  
    static void SortByLength (string[] texts)
        {

            string temp = "";
            
            for (int i = 0; i < texts.Length; i++)
            {
                for (int j = 0; j < texts.Length; j++)
                {
                    if (texts[i].Length < texts[j].Length)
                    {
                        temp = texts[i];
                        texts[i] = texts[j];
                        texts[j] = temp;

                    }


                }


            }


              

            

        }





}

