using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int lowest = int.MaxValue;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < lowest)
                {
                    lowest = nums[i];
                }
            }


            return lowest;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            string sentence = input.ToUpper();

            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            foreach (char item in input)
            {
                switch (item)
                {
                    case 'A':
                        countA += 1;
                        break;
                    case 'B':
                        countB += 1;
                        break;
                    case 'C':
                        countC += 1;
                        break;
                    case 'D':
                        countD += 1;
                        break;
                    default:
                        break;
                }
            }
            return ($"A:{countA} B:{countB} C:{countC} D:{countD}");
        }
    }
}