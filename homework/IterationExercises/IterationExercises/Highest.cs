using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            int i = 0;
            int highest = int.MinValue;


            while (i < nums.Length)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }

            return highest;
            // this method should use a while loop
        }

        public static int HighestForLoop(int[] nums)
        {
            int highest = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }


            return highest;
            // this method should use a for loop
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int highest = int.MinValue;

            foreach (int number in nums)
            {
                if (number > highest)
                {
                    highest = number;
                }
            }

            return highest;
            // this method should use a for-each loop
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int i = 0;
            int highest = int.MinValue;

            do
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            } while (i < nums.Length);


            return highest;
            // this method should use a do-while loop
        }
    }
}