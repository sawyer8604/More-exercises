using System;
using System.Linq;

namespace _1_Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(",",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetNum = int.Parse(Console.ReadLine());

            Solution solutions = new Solution(numbers, targetNum);

            int[] result = solutions.TwoSum(numbers, targetNum);
            
            Console.WriteLine($"[{ string.Join(",", result)}]");

        }

    }

}
