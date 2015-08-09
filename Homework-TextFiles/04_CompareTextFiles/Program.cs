using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


class CompareTextFiles
    {
        static void Main(string[] args)
        {
            // Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
            //  Assume the files have equal number of lines.

            StreamReader readFileOne = new StreamReader(@"..\..\File1.txt");
            string lineFileOne = readFileOne.ReadLine();
            StreamReader readFileTwo = new StreamReader(@"..\..\File2.txt");
            string lineFileTwo = readFileTwo.ReadLine();
            int equalLines = 0;
            int differentLines = 0;

            while (lineFileOne != null)
            {

                if (lineFileOne.Equals(lineFileTwo))
                {
                    equalLines++;
                }
                else
                {
                    differentLines++;
                }
                lineFileOne = readFileOne.ReadLine();
                lineFileTwo = readFileTwo.ReadLine();

            }
            readFileOne.Close();
            readFileTwo.Close();

            Console.WriteLine("There are {0} same lines and {1} different inside the two files.", equalLines, differentLines);
        }


    }


