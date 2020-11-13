using System;

namespace Lab07_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loops
            /* for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(100-i);
            }

            for (int i2 = 100; i2 >= 0 ; i2--)
            {
                Console.WriteLine(i2);
            } */

            /* int[] myArray = { 10, 20, 30 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            for (int i2 = myArray.Length - 1; i2 >= 0; i2--)
            {
                Console.WriteLine(myArray[i2]);
            } */

            // for each loops
            /* int[] myArray = { 10, 20, 30, 40 };

            foreach (var item in myArray)
            {
                Console.WriteLine(item); 
            } */

            // While loops
            /* int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine(counter*100);
                counter++;
            } */

            // Do... while
            /* int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <=10); */

            /* int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            string name = "NISH IS KING";
            name = name.ToLower();

            foreach (char item in name)
            {
                Console.WriteLine(item);
            } */

            /* for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    break;
                }
            } */
        }
    }
}
