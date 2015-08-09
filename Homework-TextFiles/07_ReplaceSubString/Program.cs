using System;
using System.IO;
using System.Text;

class ReplaceSubString
    {
        static void Main(string[] args)
        {
            // Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
            // Ensure it will work with large files (e.g. 100 MB).

            string text = File.ReadAllText(@"..\..\textfile.txt", Encoding.Unicode);
            string redacted = text.Replace("start", "finish");
            redacted = redacted.Replace("Start", "Finish");
            File.WriteAllText(@"..\..\redacted.txt", redacted, Encoding.Unicode);

        }
    }

