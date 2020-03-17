using System;

namespace _06ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = Calculator.Add(2,5);
            Console.WriteLine(b);
        }
    }
    static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        static Calculator() { }
    }
}
