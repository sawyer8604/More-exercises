using System;
using System.Linq;

namespace Final_Value_of_Variable_After_Performing_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // operations = ["--X","X++","X++"]


            string[] operations = Console.ReadLine().Split(",");

            Solution solution = new Solution();

            int result = solution.FinalValueAfterOperations(operations);

            Console.WriteLine(result);
        }
    }
}
