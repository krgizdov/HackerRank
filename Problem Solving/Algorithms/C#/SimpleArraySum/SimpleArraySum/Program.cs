namespace SimpleArraySum
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            Console.ReadLine();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOfArray = CalculateSimpleArraySum(arr);

            Console.WriteLine(sumOfArray);
        }

        static int CalculateSimpleArraySum(int[] arr)
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