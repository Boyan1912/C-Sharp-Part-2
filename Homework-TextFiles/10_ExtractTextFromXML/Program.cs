using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ExtractTextFromXML
    {
    static void Main(string[] args)
            
        {
            // Write a program that extracts from given XML file all the text without the tags.
            // <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
            // <interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

            string xmlText = File.ReadAllText(@"..\..\Rules.System.Disk.xml");
            StringBuilder text = new StringBuilder();
            int wordIndex = xmlText.IndexOf('>') + 1;


            while (wordIndex >= 0 && wordIndex <= xmlText.Length)
            {
                try
                {
                    while (!char.IsSymbol(xmlText[wordIndex]))
                    {
                        text.Append(xmlText[wordIndex]);
                        wordIndex++;
                        if (char.IsSymbol(xmlText[wordIndex]))
                        {
                            text.Append("\n");
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("End of text reached. Result:");
                    break;
                }
                
                wordIndex = xmlText.IndexOf('>', wordIndex + 1) + 1;
                
            }
           
            Console.WriteLine(text.ToString().Trim());

        }
    }

