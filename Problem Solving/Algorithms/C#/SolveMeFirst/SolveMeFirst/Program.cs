using System;

namespace SolveMeFirst
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = SolveMeFirst(num1, num2);
            Console.WriteLine(sum);
        }

        static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }
    }
}
