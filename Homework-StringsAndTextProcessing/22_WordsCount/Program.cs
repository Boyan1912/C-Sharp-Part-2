using System;
using System.Text;


class WordsCount
    {
        static void Main(string[] args)
        {

            // Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

            string text = Console.ReadLine();

            int space = 0;
            int nextSpace = text.IndexOf(' ');
            string word = "";
            int counter = 0;
            // add spaces to text in order to find occurrences of the words
            string temp = " " + text + " ";

            while (space >= 0)
            {
                // take the last word before the loop ends
                if (nextSpace < 0)
                {
                    word = text.Substring(space, text.Length - space).Trim();
                    word = " " + word + " ";
                }
                else
                {
                    // take word
                    word = text.Substring(space, nextSpace - space).Trim();
                    word = " " + word + " ";
                }
                // check if the word wasn't already counted
                if (temp.Contains(word))
                {
                    // count occurences
                    while (temp.Contains(word))
                    {
                        counter++;
                        // cut the word out
                        int wordPosition = temp.IndexOf(word);
                        // remove empty spaces next to the word in order to cut the right amount out of the text
                        word = word.Trim();
                        temp = temp.Remove(wordPosition, word.Length);
                        // add spaces again in order to be recognized as a word
                        word = " " + word + " ";
                    }
                    Console.WriteLine("{0} - {1} times", word.Trim(' ', '.', '\"', ',', '(', ')', '<', '>'), counter);
                }

                counter = 0;
                space = nextSpace;
                nextSpace = text.IndexOf(' ', space + 1);

            }
        }
    }

