using System;

namespace Lab05_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Grade(83));

            // int day = 4;

            /* switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;

                default:
                    Console.WriteLine("Weekend");
                    break;
            } */

            Console.WriteLine(Priority(1));
        }

        public static string PassFailTernary(int mark)
        {
            string grade;
            return (mark > 40) ? grade = "Pass" : grade = "Fail";
        }
        public static string Priority (int level)
        {
            string priority = "Code";
            switch (level)
            {
                case 3:
                    priority += " Red";
                    break;
                case 2:
                case 1:
                    priority += " Amber";
                    break;
                case 0:
                    priority += " Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }

            return priority;
        }

        /* public static string Grade(int mark)
        {
            var grade = "";

            if (mark >= 40)
            {
                grade = "Pass";

                if (mark >= 75)
                {
                    grade = ($"{grade} with distinction");
                }
                else if (mark >= 60)
                {
                    grade = ($"{grade} with merit");
                }

            }

            else
            {
                grade = "Fail";
            }

            return grade;
        }

        public static string PassFail (int mark)
        {
            var grade = "Fail";

            if (mark >= 40)
            {
                grade = "Pass";
            }

            return grade;
        } */


    }
}
