﻿
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> listOfIntegers = new List<int>();

            for (int i = 1; i <= max; i++)
            {
                if (i%5 == 0)
                {
                    listOfIntegers.Add(i);
                }
            }

            return listOfIntegers;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            if (argList.Count == 0)
            {
                return 0;
            }
            else
            {
                double total = 0;
                foreach (double item in argList)
                {
                    total += item;
                };

                return (total / argList.Count);
            }
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> newList = new List<string>();

            foreach (string item in sourceList)
            {
                if (item.StartsWith('A'))
                {
                    newList.Add(item);
                }
                else if (item.StartsWith('a'))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
  