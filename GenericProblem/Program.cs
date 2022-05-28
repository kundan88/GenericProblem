using System;

namespace GenericProblem

{
    class Program
    {
        public static void Main(string[] args)
        {
            FindMaxInteger maxintnum = new FindMaxInteger();
            Console.WriteLine(maxintnum.NumberMax(10, 80, 10));
        }
    }
}