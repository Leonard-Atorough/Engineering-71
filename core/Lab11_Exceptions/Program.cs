using System;
using System.IO;

namespace Lab11_Exceptions
{
    public class Program
    {
        private static string[] _theBeatles = { "Paul", "Will", "Max", "Andrew" };

        public static void ChangeBeatles(int pos, string name)
        {

            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException("Another beatle cannot be added");
            }
            else
            {
                _theBeatles[pos] = name;
            }
        }
        static void Main(string[] args)
        {
            //    try
            //    {
            //        ChangeBeatles(4, "Brian");
            //    }
            //    catch (ArgumentException e)
            //    {

            //        Console.WriteLine("1. Sorry, no fifth Beatle allowed!");
            //        Console.WriteLine($"2. {e.ToString()}");
            //        Console.WriteLine($"3. {e.Message}");
            //        Console.WriteLine($"4. {e.Data}");
            //    }
            //finally
            //{
            //    foreach (var item in _theBeatles)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //int x = 10;
            //int y = 0;

            //try
            //{
            //    Console.WriteLine(x/y);
            //}
            //catch (DivideByZeroException e)
            //{

            //    Console.WriteLine("Can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Life goes on");
            //}


            // catch heirarchy
            //try
            //{
            //    File.OpenRead("Tryex.txt");
            //}
            //catch (DirectoryNotFoundException)
            //{

            //    Console.WriteLine("Could not find Tryex directory");

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Could not find Tryex.txt");
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Could not write to file");
            //}
        }
    }
}
