using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;



class DeleteOddLines
    {
        static void Main(string[] args)
        {
            //     Write a program that deletes from given text file all odd lines.
           //      The result should be in the same file.

            string[] lines = File.ReadAllLines(@"..\..\TheRaven.txt");
            using (StreamWriter writer = new StreamWriter(@"..\..\TheRaven.txt", false, Encoding.Unicode))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        writer.WriteLine(lines[i]);

                    }
                    
                }

            }

        }
    }

