using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Lab13_File_Operations_And_Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            //FILE OPERATIONS

            // set path
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.GetFullPath(Path.Combine(path1, (@"..\..\..\\\Lyrics\")));

            //ReadAllText(string): opens text file, reads all text, closes file
            //string lyrics = File.ReadAllText(path2 + "/wonderwall.txt");
            //Console.WriteLine(lyrics);



            // WriteAllText(string, stirng), creates a new file which writes a specified string)
            //File.WriteAllText(path2 + "ChampagneSupernova.txt", "In Champagne Supernovs in the sky!");



            //WriteAllLines(string, string[]). Creates a new file which writes an array as lines
            //string[] lyrics = { "So", "Sally", "Can", "Wait" };
            //File.WriteAllLines(path2 + "/DontLookBackInAnger.TXT", lyrics);




            //Exists(string) checks if file exists

            //var path3 = path2 + @"\myLyrics.txt";

            //if(!File.Exists(path3))
            //{
            //    //create a file to write too
            //    string[] createText = { "Hello", "Friend" };
            //    File.WriteAllLines(path3, createText);
            //}



            ///Appending text
            //string appendText = "\nI got a new haircut";
            //File.AppendAllText(path3, appendText);



            //Copy(string, string, bool)
            //File.WriteAllText(path2 + @"/oldLyrics.txt", "Hey now we're friends");

            //string oldLyrics = path2 + @"/oldLyrics.txt";
            //string newLyrics = path2 + @"/newLyrics.txt";
            //File.Copy(oldLyrics, newLyrics, false);



            //Delete(string)
            //File.Delete(path2 + @"oldLyrics.txt");


            //Information about our files
            //DateTime lastWriteTime = File.GetLastWriteTime(path3);
            //DateTime creationTime = File.GetCreationTime(path3);
            //var fileInfo = new FileInfo(path3);
            //Console.WriteLine($"Last write time: {lastWriteTime} Creation Time: {creationTime}");
            //Console.WriteLine(fileInfo.DirectoryName + fileInfo.Extension);


            // FOLDER OPERATIONS
            //var fileArray = Directory.GetFiles(path2);

            //foreach (var item in fileArray)
            //{
            //    Console.WriteLine(item);
            //}

            //Create directory
            //Directory.CreateDirectory(path2 + "FolderA");



            //Delete directory
            //Directory.Delete(path2 + "FolderA");




            //LOGGING
            // We can log to a VS output window as well as the console

            //int total = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //    total++;
            //    Debug.WriteLine($"Debug - the value of i is {i}");
            //    Trace.WriteLine($"Trace - the value of i is {i}");
            //}

            //Conditional compilation 
//            Console.WriteLine("Starting app");
//#if DEBUG
//            Console.WriteLine("Debug mode");
//#endif
//            Console.WriteLine("Finishing app");


            //creating a word document, adding a paragraph of text.
            // install Docx nuget package
            //namespace Xceed.Words.Net
        }
    }
}
