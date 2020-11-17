
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsExercises
{
    public class CollectionsExercise
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            num = num > queue.Count ? queue.Count : num;

            StringBuilder result = new StringBuilder();
            //string[] entries = new string[num];

            for (int i = 0; i < num; i++)
            {
                result.Append($"{queue.Dequeue()}, ");

                //string item = queue.Dequeue();
                //entries[i] = item;
            }

            ////string output = string.join(", ", entries);
            ////return output;

            return result.Length == 0 ? "" : result.Remove(result.Length - 2, 2).ToString();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> stack = new Stack<int>(original);

            //foreach (int item in original)
            //{
            //    stack.Push(item);
            //}

            int[] output = new int[original.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = stack.Pop();
            }

            return output;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    if (dictionary.ContainsKey(c))
                    {
                        dictionary[c]++;
                    }
                    else
                    {
                        dictionary.Add(c, 1);
                    }
                }
            }

            string output = "";
            foreach (var item in dictionary)
            {
                output += string.Join(" ", $"[{item.Key}, {item.Value}]");
            }

            return output;
        }
    }
}