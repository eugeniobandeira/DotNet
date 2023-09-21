using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

            }
            catch(IOException e)
            {
                Console.WriteLine("An erro occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
