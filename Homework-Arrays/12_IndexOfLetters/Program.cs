using System;
class IndexOfLetters
    {
        static void Main()
        {
            // Write a program that creates an array containing all letters from the alphabet (A-Z).
            // Read a word from the console and print the index of each of its letters in the array.

            char[] lettersArray = new char[26];
            char a = 'a';

            for (int i = 0; i < lettersArray.Length; i++)
            {
                lettersArray[i] = a;
                a++;
                
            }

            string word = Console.ReadLine();

            for (int i = 0; i < lettersArray.Length; i++)
            {
                foreach (char letter in word)
                {
                    
                    if (letter == lettersArray[i])
                    {
                        Console.WriteLine("The index of {0} in the array is {1}", letter, i);
                    }

                    if (letter + 32 == lettersArray[i]) // Това за да печати и големите букви; по АСКИ таблицата малка буква + 32 = голяма буква
                    {
                        Console.WriteLine("The index of {0} in the array is {1}", letter, i);
                    }

                }

            }
        
        }
    }

