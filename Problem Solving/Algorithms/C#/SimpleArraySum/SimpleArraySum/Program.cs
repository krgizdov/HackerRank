namespace SimpleArraySum
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfArray = SimpleArraySum(arr);

            Console.WriteLine(sumOfArray);
        }

        static int SimpleArraySum(int[] arr)
        {
            int sumOfArray = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumOfArray += arr[i];
            }

            return sumOfArray;
        }
    }
}