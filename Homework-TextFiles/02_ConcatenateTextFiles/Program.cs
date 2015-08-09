using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            // Write a program that concatenates two text files into another text file.


            // get the content of the first file:
            string textFileOne = File.ReadAllText(@"..\..\FileOne.txt");
            // append the content to the non-existing "Concatenated.txt". "Concatenated.txt" will be created by the method
            File.AppendAllText(@"..\..\Concatenated.txt", textFileOne);
            // append the second file's content
            File.AppendAllText(@"..\..\Concatenated.txt", File.ReadAllText(@"..\..\FileTwo.txt"));
        }
    }

