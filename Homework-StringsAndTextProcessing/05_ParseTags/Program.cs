using System;
using System.Text;



class ParseTags
    {
        static void Main()
        {

            // You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
            // The tags cannot be nested.
            string text = Console.ReadLine(); //"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int indexStart = 0;
            int indexEnd = text.IndexOf('<');

            StringBuilder redacted = new StringBuilder();
            bool upperCase = false;

            while (indexEnd > 0)
            {
                if (upperCase)
                {
                    redacted.Append(text.ToUpper(), indexStart, indexEnd - indexStart);
                    upperCase = false;
                }
                else
                {
                    redacted.Append(text, indexStart, indexEnd - indexStart);
                    upperCase = true;
                }
                indexStart = indexEnd;
                indexEnd = text.IndexOf('<', indexEnd + 1);

            }

            redacted.Append(text, indexStart, text.Length - indexStart);
            redacted.Replace("<upcase>", null);
            redacted.Replace("</upcase>", null);
            redacted.Replace("<UPCASE>", null);
            redacted.Replace("</UPCASE>", null);

            Console.WriteLine(redacted.ToString());
        }
    }

