﻿using System;

namespace SelectionExercisesLib
{
    public class Exercises
    {
        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            return (num % 2 == 0) ? true : false;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        // Throw an ArgumentException if age is less than 0
        public static string TicketType(int age)
        {
            string ticketType;

            if (age < 0)
            {
                throw new ArgumentException("Age cannot be less than 0");
            }

            else
            {
                if (age >= 60)
                {
                    ticketType = "OAP";
                }

                else if (age >= 13 & age <= 17)
                {
                    ticketType = "Student";
                }
                else if (age >= 5 & age <= 12)
                {
                    ticketType = "Child";
                }
                else if (age < 5)
                {
                    ticketType = "Free";
                }
                else
                {
                    ticketType = "Standard";
                }
            }

            return ticketType;
        }
    }
}