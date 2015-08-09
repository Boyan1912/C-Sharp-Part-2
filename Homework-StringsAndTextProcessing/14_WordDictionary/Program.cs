using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class WordDictionary
    {
        static void Main(string[] args)
        {
            // A dictionary is stored as a sequence of text lines containing words and their explanations.
            // Write a program that enters a word and translates it by using the dictionary.

            Console.WriteLine("Enter the term you are searching for, e.g. \".NET\", \"CLR\" or \"namespace\": ");
            string term = Console.ReadLine();

            Dictionary<string, string> dictionary = new Dictionary<string,string>();

            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            if (dictionary.ContainsKey(term))
            {
                Console.WriteLine("{0} is {1}", term, dictionary[term]);
            }

            else
            {
                Console.WriteLine("There is no such a term in the dictionary");
            }

        }
    }

