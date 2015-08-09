using System;
class ReplaceTags
    {
        static void Main()
        {
            // Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            string redacted = input.Replace("<a href=\"", "[URL=");
            redacted = redacted.Replace("\">", "]");
            redacted = redacted.Replace("</a>", "[/URL]");
            
            Console.WriteLine(redacted);
        }
    }

