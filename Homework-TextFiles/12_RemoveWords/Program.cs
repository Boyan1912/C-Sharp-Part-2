using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class RemoveWords
    {
        static void Main(string[] args)
        {
            // Write a program that removes from a text file all words listed in given another text file.
            
            string input = File.ReadAllText(@"..\..\input.txt");
            string[] instructions = File.ReadAllLines(@"..\..\instructions.txt");
            
            for (int i = 0; i < instructions.Length; i++)
            {
                int wordStart = input.IndexOf(instructions[i]);
                while (wordStart >= 0)
                {
                    input = input.Remove(wordStart, instructions[i].Length);
                    wordStart = input.IndexOf(instructions[i], wordStart + 1);

                }
            }
            File.WriteAllText(@"..\..\output.txt", input);
        }
    }

