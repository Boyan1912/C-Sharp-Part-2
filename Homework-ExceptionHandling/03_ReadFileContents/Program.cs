using System;
using System.IO;
using System.Text;
using System.Security;

class ReadFileContents
    {
        static void Main()
        {
            // Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
            // Find in MSDN how to use System.IO.File.ReadAllText(…).
            // Be sure to catch all possible exceptions and print user-friendly error messages.

            Console.WriteLine("Enter file path: ");
            string filePath = Console.ReadLine();   //@"C:\WINDOWS\win.ini";

            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }

            catch (SecurityException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }

