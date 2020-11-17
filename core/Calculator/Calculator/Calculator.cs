using System;

namespace Calculator
{
    public class CalculatorMethods
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Product(double x, double y)
        {
            return x * y;
        }

        public static double Quotient(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Error");
            }
            else
            {
                return x / y;
            }
        }

        public static double Modulus(double x, double y)
        {
            return x % y;
        }
    }
}
