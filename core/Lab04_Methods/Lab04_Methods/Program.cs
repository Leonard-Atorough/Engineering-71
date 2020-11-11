using System;

namespace Lab04_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var output = DoThatAgain(4, 12);
            // Console.WriteLine($"The answer is {output}");
            /* int a = 10;
            Add(a);
            int b = 10;
            Add(ref b); */

            // var myTuple = ("Leo", "Atorough", 24);

            // string movie = "Nottig Hill";
            // int views = 1;

            // var myTuple2 = (movie, views);

            // var result = TupleExample(12, "have a string");
            // Console.WriteLine(result.xs);

            var result = TripleCalc(2, 4, 6, out int total);
            Console.WriteLine(result);
            Console.WriteLine(total);

            var result2 = TripleCalc(2, 4, 6);
            Console.WriteLine(result2.sum);
            Console.WriteLine(result2.product);
        }

        public static int TripleCalc (int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sum, int product) TripleCalc (int a, int b, int c)
        {
            return (a + b + c, a * b * c);
        }

        /* public static (int xs, bool isLarge) TupleExample(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);
            return (x * x , z); 
        } */

        /*  public static int DoThis()
        {
            Console.WriteLine("I am doing something");
            return 100;
        } */

        /* public static int DoThatAgain(int x, int y)
        {
            Console.WriteLine($"We are multiplying {x} by {y}");
            return x * y;
        } */

        /* public static int DoThatAgain (int x, string y = "Default")
        {
            Console.WriteLine(y);
            return x * x;
        } */

        /* static void Add (int x)
        {
            x++;
        }

        static void Add (ref int x)
        {
            x++;
        } */

        
    }
}
