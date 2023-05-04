using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long maxSum = long.MinValue;
        long minSum = long.MaxValue;


        for (int i = 0; i < arr.Count; i++)
        {
            long crrMaxSum = arr[0];
            long crrMinSum = arr[0];            

            for (int j = 1; j < arr.Count - 1; j++)
            {
                crrMaxSum += arr[j];
                crrMinSum += arr[j];                
            }
            int crrElement = arr[0];

            for (int k = 0; k < arr.Count -1; k++)
            {
               
                arr[k] = arr[k + 1];
               
            }

            arr[arr.Count - 1] = crrElement;


            if (crrMaxSum > maxSum)
            {
                maxSum = crrMaxSum;
            }

            if (crrMinSum < minSum)
            {
                minSum = crrMinSum;
            }
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
