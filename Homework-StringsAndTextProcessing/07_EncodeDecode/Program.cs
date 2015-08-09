using System;
using System.Text;

class EncodeDecode
    {
        static void Main()
        {
             // Write a program that encodes and decodes a string using given encryption key (cipher).
             // The key consists of a sequence of characters.
             // The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – 
             // with the second, etc. When the last key character is reached, the next is the first.

            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode; 

            Console.WriteLine("Enter cipher: ");
            char[] cipher = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter Text: ");
            char[] text = Console.ReadLine().ToCharArray();

            EncodeDecode(cipher, text);

        }

        static void EncodeDecode(char[] cipher, char[] text)
        {
            StringBuilder encodedMessage = new StringBuilder();
            int i = 0;
            int j = 0;

            while (i < text.Length)
            {
                text[i] ^= cipher[j];
                encodedMessage.Append(text[i]);

                i++;
                j++;

                if (j == cipher.Length)
                {
                    j = 0;
                }
            }
            Console.WriteLine(encodedMessage.ToString());
        }

}

