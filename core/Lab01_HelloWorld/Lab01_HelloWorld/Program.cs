using System;

namespace Lab01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 100;
             x += 10;

             for(int i = 0; i <= 10; i++)
             {
                 Console.WriteLine(i);
                 x += i; 
             } */

            Console.WriteLine("Hello, Command line test.");

            foreach(string name in args)
            {
                Console.WriteLine($"{name} is in my class");
            }
        }
    }
}
