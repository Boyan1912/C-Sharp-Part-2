using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class ExtractEMails
    {
        static void Main(string[] args)
        {
            // Write a program for extracting all email addresses from given text.
            // All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

            Console.WriteLine("Enter text here: ");
            string text = Console.ReadLine();

            StringBuilder listEmails = new StringBuilder();
            int indexEmail = 0;
            int endEmail = 0;

            while (true)
            {
                // determine index of E-mail:
                indexEmail = text.IndexOf('@');
                if (indexEmail < 0) // = no more e-mail addresses
                {
                    break;
                }
                // determine end of Email:
                endEmail = text.IndexOf(' ', indexEmail);
                // in case the last word in the text is also an E-mail address:
                if (endEmail < 0)
                {
                    int lastSpace = text.LastIndexOf(' ');
                    string emailLastWord = text.Substring(lastSpace, text.Length - lastSpace);
                    listEmails.Append(emailLastWord.Trim(' ', '.') + "\n");
                    break;
                }
                // get the whole text up to the E-mail address:
                string emailFound = text.Substring(0, text.Length - (text.Length - endEmail));
                // extract E-mail address (the last word):
                string emailAddress = emailFound.Substring(emailFound.LastIndexOf(' '), emailFound.Length - emailFound.LastIndexOf(' '));
                // add to list:
                listEmails.Append(emailAddress.Trim() + "\n");
                // remove used text:
                text = text.Remove(0, emailFound.Length);
            }

            Console.WriteLine("List E-mails: {0} ", listEmails);
        }
    }

