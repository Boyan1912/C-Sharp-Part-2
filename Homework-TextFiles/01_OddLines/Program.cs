using System;
using System.IO;


class OddLines
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and prints on the console its odd lines.

            using (StreamReader reader = new StreamReader(@"..\..\textFile.txt"))
            {
                int row = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    row++;
                    line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (row % 2 != 0)
                    {
                        Console.WriteLine("Row {0}: {1}", row, line);
                    }

                }

            }
        }
    }

