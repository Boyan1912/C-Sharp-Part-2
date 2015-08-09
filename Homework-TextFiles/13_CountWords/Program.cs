using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountWords
    {
        static void Main(string[] args)
        {
            // Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
            // The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
            // Handle all possible exceptions in your methods.

            string[] words = File.ReadAllText(@"..\..\words.txt").ToLower().Split(' ');
            string text = File.ReadAllText(@"..\..\test.txt").ToLower();
            int occurances = 0;
            int[] results = new int[words.Length];
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                
                occurances = text.IndexOf(words[i]);
                
                while (occurances >= 0)
                {
                    results[i]++;
                    occurances = text.IndexOf(words[i], occurances + 1);

                }
                dict.Add(words[i], results[i]);
                
            }
            // lambda expression
            var output = dict.OrderByDescending(x => x.Value);

            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                foreach (var pair in output)
                {

                    writer.WriteLine("{0}  {1}", pair.Key, pair.Value);

                }
            }           
        }
    }

