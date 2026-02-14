using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14
{
    public class Program2
    {
        public delegate double NumericFunction(double d);
        static double factor = 4.0;

        public static NumericFunction MakeMultiplier(double factor)
        {
            return delegate (double input) { return input * factor; };
        }

        public static void Main()
        {
            NumericFunction f = MakeMultiplier(3.0);
            double input = 5.0;

            Console.WriteLine("factor = {0}", factor);
            Console.WriteLine("input = {0}", input);
            Console.WriteLine("f is a generated function which multiplies its input with factor");
            Console.WriteLine("f(input) = input * factor = {0}", f(input));
        }
    }
}
