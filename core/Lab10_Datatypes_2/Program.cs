using System;
using System.Diagnostics;

namespace Lab10_Datatypes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATETIME & TIMESPAN

            //var tps = TimeSpan.TicksPerSecond;
            //var nowInTicks = DateTime.Now.Ticks;

            //var d = new DateTime();
            //var d1 = DateTime.Today;
            //var d2 = DateTime.Now;
            //var d3 = new DateTime(1996, 11, 26, 6, 0, 0);

            //var age = d2 - d3;
            //var result = (age.Days / 365.25);

            //Console.WriteLine(Math.Floor(result));

            //var timespan = new TimeSpan(1, 0, 0);
            //var d4 = new DateTime(1996, 11, 26, 6, 0, 0);
            //var date = d4 + timespan;

            //var stopwatch = new Stopwatch();

            //stopwatch.Start();
            //int total = 0;

            //for (int i = 0; i <= 100000; i++)
            //{
            //    total++;
            //}

            //stopwatch.Stop();

            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //Console.WriteLine(stopwatch.ElapsedTicks);
            //Console.WriteLine(stopwatch.Elapsed);
            //Console.ReadLine();

            //Suit newSuit = (Suit)20;

            //var thisSuit = newSuit.ToString();
            //Suits(newSuit);

            //var monday = 1;
            //var day = (DayOfWeek)monday;

            //Console.WriteLine(day);

            //int dog;
            //float cat;
            //char c;
            //DateTime aDtae;
            //string aString;
            //bool thing;
            //int[] intarray;

            //int sparts;
            //int? globs;

            //    bool? hasPassed = true;

            //    if (hasPassed.HasValue)
            //    {
            //        Console.WriteLine($"hasPassed has a value of {hasPassed}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Has passed has a value of null");
            //    }

            //    int totalCost = 0;
            //    int price = 5;

            //    int? items = null;

            //    if (items.HasValue)
            //    {
            //        totalCost = price * items.Value;
            //    }
            //    Console.WriteLine(items.HasValue);
            //    Console.WriteLine(totalCost);
            // 


            // const
            // const int dozen = 12;

            // dynamic allows us to break strong typing. Don't use

            //dynamic item = 100;

            //Console.WriteLine($"Adding 10 to {item} gives {item + 10}");

            //item = "Hello";
            //Console.WriteLine($"Adding 10 to {item} gives {item + 10}");

            // Random class

            //var rng = new Random();
            //var rngSeeded = new Random(42);

            //var between1And10 = rngSeeded.Next(1, 11);

            //Console.WriteLine(between1And10);

            var rollTheDice = new Random();

            var dice1 = rollTheDice.Next(7);
            var dice2 = rollTheDice.Next(7);
            var dice3 = rollTheDice.Next(7);

        }

        public static void Suits (Suit suit)
        {
            switch (suit)
            {
                case Suit.HEARTS:
                    Console.WriteLine("You have stolen a Heart!");
                    break;
                case Suit.DIAMONDS:
                    Console.WriteLine("You have stolen a Diamond!");
                    break;
                case Suit.CLUBS:
                    Console.WriteLine("You have stolen a Club!");
                    break;
                case Suit.SPADES:
                    Console.WriteLine("You have stolen a Spade!");
                    break;
                default:
                    break;
            }
        }

        public enum Suit
        {
            HEARTS = 20, DIAMONDS, CLUBS, SPADES
        }
    }
}
