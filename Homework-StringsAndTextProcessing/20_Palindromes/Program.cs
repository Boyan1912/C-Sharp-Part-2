using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Palindromes
    {
        static void Main(string[] args)
        {
            // Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
            // A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. 
            // Allowances may be made for adjustments to capital letters, punctuation, and word dividers.

            string text = Console.ReadLine();

            int space = 0;
            int nextSpace = text.IndexOf(' ', 0);
            int count = 0;
            string word = "";

            while (space >= 0)
            {
                // take the last word before the loop ends
                if (nextSpace < 0)
                {
                    word = text.Substring(space, text.Length - space).Trim().ToLower();
                }
                else
                {
                    // take each word in the text
                    word = text.Substring(space, nextSpace - space).Trim().ToLower();
                }
                // check if symbols match each other
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i].Equals(word[word.Length - 1 - i]))
                    {
                        count++;
                        if (count == word.Length / 2)
                        {
                            Console.WriteLine(word);
                        }
                    }
                }
                count = 0;
                space = nextSpace;
                nextSpace = text.IndexOf(' ', space + 1);
            }
        }
    }

