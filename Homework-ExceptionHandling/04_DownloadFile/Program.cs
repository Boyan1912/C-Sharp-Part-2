using System;
using System.Net;
using System.IO;

class DownloadFile
    {
        static void Main(string[] args)
        {
            /*     Write a program that downloads a file from Internet (e.g. Ninja image) and stores it in the current directory.
                   Find in Google how to download files in C#.
                   Be sure to catch all exceptions and to free any used resources in the finally block.*/

            Console.WriteLine("Enter Internet file address: "); // https://telerikacademy.com/Content/Images/news-img01.png
            string internetAddress = Console.ReadLine();
            string extension = internetAddress.Substring(internetAddress.LastIndexOf('.'), internetAddress.Length - internetAddress.LastIndexOf('.'));

            using (WebClient internetRover = new WebClient())
            {
                try
                {
                    Console.WriteLine("Recieving data...");
                    internetRover.DownloadFile(internetAddress, "downloadedFile" + extension);
                    Console.WriteLine("File successfully downloaded! File Location:...\\bin\\Debug");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }

