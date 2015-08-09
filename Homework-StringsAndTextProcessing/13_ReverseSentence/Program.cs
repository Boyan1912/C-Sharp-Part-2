using System;
using System.Text;


class ReverseSentence
    {
        static void Main(string[] args)
        {
            // Write a program that reverses the words in given sentence.

            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();  //"C# is not C++, not PHP and not Delphi!";
            
            int lastWordIndex = input.LastIndexOf(' ');
            StringBuilder reverse = new StringBuilder();

            while (lastWordIndex > 0)
            {
                string lastWord = input.Substring(lastWordIndex, input.Length - lastWordIndex);
                reverse.Append(lastWord);
                input = input.Remove(lastWordIndex, input.Length - lastWordIndex);
                lastWordIndex = input.LastIndexOf(' ', lastWordIndex - 1);

            }
            // add the first word
            reverse.Append(" " + input);

            Console.WriteLine(reverse.ToString().TrimStart());
        }
    }

