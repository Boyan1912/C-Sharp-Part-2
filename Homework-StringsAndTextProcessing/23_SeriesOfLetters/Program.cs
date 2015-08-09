using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            // Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

            string text = Console.ReadLine(); // aaaaabbbbbcdddeeeedssaa
            string repeatedLetter = "";
            string redactedText = text;

            for (int i = 0; i < text.Length - 1; i++)
            {
                
                if (text[i].Equals(text[i+1]))
                {
                    repeatedLetter += text[i];
                }
                else
                {
                    // find index of next repeated letter (otherwise in case: "abbbbaaaaa" would find the first "a"'s index)
                    int replaceIndex = redactedText.IndexOf(repeatedLetter);
                    while (replaceIndex < redactedText.Length - 1 && redactedText[replaceIndex] != redactedText[replaceIndex + 1])
                    {
                        replaceIndex++;
                    }
                    redactedText = redactedText.Remove(replaceIndex, repeatedLetter.Length);
                    repeatedLetter = "";
                }
                if (i + 2 == text.Length) // end of text is reached
                {
                    redactedText = redactedText.Remove(redactedText.LastIndexOf(repeatedLetter), repeatedLetter.Length);
                }
            }
            Console.WriteLine(redactedText);

        }
    }

