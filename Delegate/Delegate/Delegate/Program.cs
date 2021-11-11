using System;

namespace Delegate
{
    delegate int Solve(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Solve sum = new Solve(Sum);
            Console.WriteLine("Sum: "+sum(a,b));

            Solve division = new Solve(Division);
            Console.WriteLine("Division: "+division(a,b));

            Solve subtraction = new Solve(Subtraction);
            Console.WriteLine("Subtraction: "+subtraction(a,b));

            Solve multiplication = new Solve(Multiplication);
            Console.WriteLine("Multiplication: "+ multiplication(a,b));
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
