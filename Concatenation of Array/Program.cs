using System;
using System.Linq;

namespace Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nums = [1,2,1]

            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Solution solution = new Solution();

            int[] result = solution.GetConcatenation(numbers);

            Console.WriteLine($"[{string.Join(",", result)}]");
        }
    }
}
