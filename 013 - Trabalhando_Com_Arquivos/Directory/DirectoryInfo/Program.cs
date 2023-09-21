using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            
            try
            {
               //List all folders
               IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOptions.AllDirectories);
               Console.WriteLine("Folders:")
               foreach(string s in folders) {
                    Console.WriteLine(s);     
               }

                //List all files
                var files = Directory.EnumerateFiles(path, "*.*", SearchOptions.AllDirectories);
                Console.WriteLine("files:")
               foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

               //Create a new folder
               Directory.CreateDirectory(path + @"\newestFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
