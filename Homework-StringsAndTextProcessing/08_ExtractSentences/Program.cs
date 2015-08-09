using System;

    class ExtractSentences
    {
        static void Main()
        {
            // Write a program that extracts from a given text all sentences containing given word.

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            // "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Enter word: ");
            string word = " " + Console.ReadLine() + " ";
            Console.WriteLine("The sentences containing the word \"{0}\" are:", word);
            
            ExtractSentence(text, word);

        }
    
    static void ExtractSentence (string text, string word)
        {
            int startSentence = 0;
            int endSentence = text.IndexOf('.');
            while (endSentence > 0)
            {
                string sentence = text.Substring(startSentence, endSentence - startSentence + 1).TrimStart('.');
                if (sentence.Contains(word))
                {
                    Console.Write(sentence);
                }
                startSentence = endSentence;
                endSentence = text.IndexOf('.', endSentence + 1);
            
            }

        }
    
    }

