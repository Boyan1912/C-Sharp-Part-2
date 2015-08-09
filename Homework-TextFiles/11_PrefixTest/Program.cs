using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class PrefixTest
    {
        static void Main(string[] args)
        {
            // Write a program that deletes from a text file all words that start with the prefix test.
            // Words contain only the symbols 0…9, a…z, A…Z, _.

            string input = File.ReadAllText(@"..\..\input.txt");
            int testIndex = input.IndexOf("test");
            string word = "test";
            int wordLength = 0;
            string wordToDelete = "";
            string output = input;

            while (testIndex >= 0)
            {
                while (char.IsLetterOrDigit(input[testIndex + "test".Length + wordLength]) || input[testIndex + "test".Length + wordLength].Equals('_'))
                {
                    word += input[testIndex + "test".Length + wordLength];
                    wordLength++;
                }
                wordToDelete = word;
                output = output.Replace(wordToDelete, string.Empty);
                word = "test";
                wordLength = 0;
                testIndex = input.IndexOf("test", testIndex + 1);
            }
            File.WriteAllText(@"..\..\output.txt", output);
        
        }
    }

