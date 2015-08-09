using System;

class ExtractTextFromHTML
    {
        static void Main()
        {
            // Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

            string input = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""""http://academy.telerik.com\"""">
Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";

            int titleStart = input.IndexOf("<title>");
            int titleEnd = input.IndexOf("</title>");

            string title = input.Substring(titleStart + "<title>".Length, titleEnd - (titleStart + "<title>".Length));

            int bodyStart = input.IndexOf("<body>");
            int bodyEnd = input.IndexOf("</body>", bodyStart);
            input = input.Substring(bodyStart + "<body>".Length, bodyEnd - (bodyStart + "<body>".Length));

            int tagStart = input.IndexOf('<');
            int tagEnd = input.IndexOf('>');

            while (tagStart >= 0)
            {
                string tag = input.Substring(tagStart, tagEnd + 1 - tagStart);

                input = input.Replace(tag, " ");

                tagStart = input.IndexOf('<');
                tagEnd = input.IndexOf('>');

            }

            Console.WriteLine("Title: {0}\n\n{1}", title, input.Trim());
           
        }
    }

