using System;

class ForbiddenWords
    {
        static void Main(string[] args)
        {
            // We are given a string containing a list of forbidden words and a text containing some of these words.
            // Write a program that replaces the forbidden words with asterisks.

            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
            string result = "";
            string redactedText = text;

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                if (text.Contains(forbiddenWords[i]))
                {
                    result = redactedText.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
                    redactedText = result;  // пази стойността от последната промяна, иначе ако работи директно върху text ще изкара текста само с последната промяна
                }

            }
            Console.WriteLine(redactedText);
            
        }
    }

