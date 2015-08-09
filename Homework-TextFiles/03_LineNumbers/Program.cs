using System;
using System.IO;

class LineNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and inserts line numbers in front of each of its lines.
            // The result should be written to another text file.

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                string line = reader.ReadLine();
                int row = 0;
                StreamWriter writer = new StreamWriter(@"..\..\redactedText.txt");
                while (line != null)
                {
                    writer.WriteLine("Line No {0}: {1}", row + 1, line);
                    row++;
                    line = reader.ReadLine();

                }
                writer.Close();
            }



        }
    }

