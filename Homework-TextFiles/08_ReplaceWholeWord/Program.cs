using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class ReplaceWholeWord
    {
        static void Main(string[] args)
        {
            // Modify the solution of the previous problem to replace only whole words (not strings).

            string text = File.ReadAllText(@"..\..\textfile.txt");
            text = text.Replace(" start ", " finish ");
            text = text.Replace(" Start ", " Finish ");

            int startStringIndex = text.IndexOf("start");
            while (startStringIndex >= 0)
            {
                char determinator = text[startStringIndex + "start".Length + 1];
                
                if (!char.IsLetterOrDigit(determinator))
                {
                    text = text.Replace("start", "finish");
                }
                startStringIndex = text.IndexOf("start", startStringIndex + 1);
            }

            File.WriteAllText(@"..\..\redacted.txt", text);
        }
    }

