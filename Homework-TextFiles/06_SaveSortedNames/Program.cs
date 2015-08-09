using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SaveSortedNames
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string word = reader.ReadLine();

                var names = new List<string>();
                while (word != null)
                {
                    names.Add(word);
                    word = reader.ReadLine();
                }
                // lambda expression
                var sorted = names.ToArray();
                Array.Sort(sorted);
                    using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
                    {
                        for (int i = 0; i < sorted.Length; i++)
                        {
                            writer.WriteLine(sorted[i]);
                        }

                    }
            }
        }
    }

