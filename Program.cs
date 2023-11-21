using System;
using System.Diagnostics;
using System.IO;

namespace WebPageRedirect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current directory of the application
            string currentDirectory = Directory.GetCurrentDirectory();

            // Construct the file path for index.htm
            string filePath = Path.Combine(currentDirectory, "index.htm");

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Open the file using the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("File not found: " + filePath);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
