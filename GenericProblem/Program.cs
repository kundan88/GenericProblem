using System;

namespace GenericProblem

{
    class Program
    {
        public static void Main(string[] args)
        {
            FindMaxInteger maxintnum = new FindMaxInteger();
            Console.WriteLine(maxintnum.NumberMax(10, 80, 10));
            Console.WriteLine("-------------------------");
            FindMaxFloat maxfloatnum = new FindMaxFloat();
            Console.WriteLine(maxfloatnum.FloatNumber(90.4f, 50.6f, 70.7f));
            Console.WriteLine("find Max String");
            string output = FindMaxString.MaximumString("Hi", "This", "is");
            Console.WriteLine(output);
        }
    }
}