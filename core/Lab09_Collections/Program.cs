using System;
using System.Collections.Generic;

namespace Lab09_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            /* var numbers = new List<int> {11, 31, -4, 6, 0 };

            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            numbers.Add(24);
            numbers.Add(-45);
            numbers.Add(3);

            numbers[2] = 4;

            numbers.Reverse();

            numbers.RemoveAt(3);

            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            numbers.Sort();

            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine(); */


            // QUEUE FIRST IN, FIRST OUT
            //var myQueue = new Queue<string>();

            //myQueue.Enqueue("Will");
            //myQueue.Enqueue("Arthur");
            //myQueue.Enqueue("Bill");

            //Console.WriteLine(myQueue.Dequeue());

            //foreach (string item in myQueue)
            //{
            //    Console.Write($"{item} ");
            //}

            // STACK LAST IN, FIRST OUT

            //var myStack = new Stack<string>();

            //myStack.Push("Chair 1");
            //myStack.Push("Chair 2");
            //myStack.Push("Chair 3");

            //foreach (string item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //myStack.Pop();

            //foreach (string item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            // HashSet<T> - unordered collections

            //var eng71 = new HashSet<string> {"Nish", "Paula", "Lee", "Cathy", "Lee"};

            //var count = eng71.Count;
            //Console.WriteLine(count);


            //foreach (string item in eng71)
            //{
            //    Console.WriteLine(item);
            //}        

            //DICTIONARY

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            //myDictionary.Add(1, "Paula");
            //myDictionary.Add(2, "David");
            //myDictionary.Add(3, "Lee");
            //myDictionary.TryAdd(3, "Leonard");

            //foreach (var item in myDictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //var dictionar2020 = new Dictionary<char, string> { { 'a', "Aligator" }, { 'b', "Baboon" } };

            //var p = dictionar2020['a'];

            //Console.WriteLine(p);

            //foreach (var key in dictionar2020.Keys)
            //{
            //    Console.WriteLine($"The key is {key} and the value is {dictionar2020[key]}");
            //}

            string input = "The quick brown fox jumps over the lazy dog";

            var dictionary = new Dictionary<char, int>();

            foreach (char c in input)
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

            foreach (var item in dictionary)
            {
                Console.WriteLine($"there are {item.Value} instances of {item.Key} in the string");
            }
        }
    }

}
