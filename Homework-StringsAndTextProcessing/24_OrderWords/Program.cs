using System;
using System.Collections.Generic;



class OrderWords
    {
        static void Main(string[] args)
        {
            // Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

            List<string> listWords = new List<string>();
            string[] words = Console.ReadLine().ToLower().Split(' ');
           
            // add the words into a list
            for (int i = 0; i < words.Length; i++)
            {
                listWords.Add(words[i].Trim());
            }

            // make a new list for the arranged words
            List<string> arranged = new List<string>();
            string bestWord = "";
            int bestIndex = 0;

            while (listWords.Count > 0)
            {
                bestWord = listWords[0];
                for (int i = 0; i < listWords.Count; i++)
                {
                    // determine which word from the list should be first in an alphabetical order
                    bestWord = CompareWords(bestWord, listWords[i]);
                    // determine the index the word is in the list
                    if (bestWord.Equals(listWords[i]))
                    {
                        bestIndex = i;
                    }
                }
                // add to the new list
                arranged.Add(bestWord);
                // remove from the old list
                listWords.Remove(listWords[bestIndex]);
            }

            // print the result
            for (int i = 0; i < arranged.Count; i++)
            {
                Console.WriteLine(arranged[i]);
            }

        }
   
    static string CompareWords (string wordOne, string wordTwo)
        {
            string preceedingWord = wordOne;
            int index = 0;
          
            while (index < wordOne.Length && index < wordTwo.Length)
            {
                
                if (wordOne[index] < wordTwo[index])
                {
                    preceedingWord = wordOne;
                    break;
                }
                else if (wordOne[index] > wordTwo[index])
                {
                    preceedingWord = wordTwo;
                    break;
                }

                else if (wordOne[index] == wordTwo[index])
                {
                    index++;
                }

            }

            return preceedingWord;

        }


}

