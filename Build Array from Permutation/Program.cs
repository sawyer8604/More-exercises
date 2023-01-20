using System;
using System.Linq;

namespace Build_Array_from_Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nums = [5,0,1,2,3,4]

            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Solution solution = new Solution();

            int[] result = solution.BuildArray(numbers);

            Console.WriteLine($"[{string.Join (",", result)}]");
        }
    }
}
