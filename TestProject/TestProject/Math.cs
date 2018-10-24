using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Math
    {
        private double number1 = 0.0d;
        private double number2 = 0.0d;
        private double result = 0.0d;

        public double add(double a, double b)
        {
            number1 = a;
            number2 = b;

            return result = a + b;
        }

        public double substract(double a, double b)
        {
            number1 = a;
            number2 = b;

            return result = a - b;
        }

        public double multiply(double a, double b)
        {
            number1 = a;
            number2 = b;

            return result = a * b;
        }

        public double divide(double a, double b)
        {
            number1 = a;
            number2 = b;

            return result = a / b;
        }
    }
}
