using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_arrays_and_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // char[] charArray = new char[4];

            // charArray[2] = 'N';

            // Console.WriteLine(charArray);

            // arrays can have multiple dimensions

            // int [,] grid = new int[2, 4];

            // int[,] grid2 = new int[2, 4] { {1, 2, 3, 4}, {4, 3, 2, 1} };

            // var x = grid2[0, 3] * grid2[1, 0];

            /* string[][] animalGrid = new string[][]
            {
                new string[] {"Kamal", "Gino", "Mansib"},
                new string[] {"Lauren", "Beanca", "Breesha"}

            };

            char[][] str = new char[5][];
            str[0] = new char[5];
            str[1] = new char[2];
            str[2] = new char[10];
            str[3] = new char[3];
            str[4] = new char[4];

            str[0][0] = 'a';
            str[0][1] = 's';
            str[0][2] = 'd';
            str[0][3] = 'f';
            str[0][4] = 'g'; */


            // Console.WriteLine(x);

            /* List<string> theBeatles = new List<string> { "John Lennon", "Ringo Star" };

            theBeatles.Add("Paul McCartney");
            theBeatles.Add("George Harrison"); */

            /* string name = "Leonard";

            int length = name.Length;

            var nameUpper = name.ToUpper();

            var spaceName = "    Breesha      ";
            spaceName.Trim(); */

            /* string input = "66";

            bool result = int.TryParse(input, out int numApples);

            if (result)
            {
                Console.WriteLine(numApples);
            }
            else
            {
                Console.WriteLine("Fail!");
            } */

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello.\n");
            sb.Append("What's your name?\n");

            Console.WriteLine(sb);
        }
    }
}
