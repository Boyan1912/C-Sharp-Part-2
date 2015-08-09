using System;


class LettersCount
    {
        static void Main(string[] args)
        {
            // Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

            string text = Console.ReadLine();
            int counter = 0;

            foreach (char letter in text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (letter.Equals(text[i]) && char.IsLetter(letter))
                    {
                        counter++;
                    }
                }
                if (char.IsLetter(letter))
                {
                    Console.WriteLine("{0} - {1} times", letter, counter);
                }
                counter = 0;
            }
        }
    }

