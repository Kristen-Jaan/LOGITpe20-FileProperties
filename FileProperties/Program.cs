using System;
using System.Collections.Generic;
using System.IO;

namespace FileProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");

            //to get the file names only
            string rootPath = @"C:\Users\opilane\Samples";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
              
                //get file objects
                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                //Console.WriteLine($"File name: {fileName}; location: {fileDirectory}; Size: {fileSize}");
                string line = $"File name: {fileName}; location: {fileDirectory}; Size: {fileSize} bytes";
                lines.Add(line);
            }

            string fileDataPath = @"C:\Users\opilane\Samples\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);

        }
    }
}
