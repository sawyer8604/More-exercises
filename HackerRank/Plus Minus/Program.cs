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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int countOfPositiveElements = 0;
        int countOfNegativeElements = 0;
        int countOfZeroElements = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if(arr[i] > 0)
            {
                countOfPositiveElements++;
                continue;
            }
            else if (arr[i] < 0)
            {
                countOfNegativeElements++;
                continue;
            }
            countOfZeroElements++;
        }

        decimal positiveResult = (decimal)countOfPositiveElements / arr.Count;
        decimal negativeResult = (decimal)countOfNegativeElements / arr.Count;
        decimal zeroResult = (decimal)countOfZeroElements / arr.Count;

        Console.WriteLine($"{positiveResult:f6}");
        Console.WriteLine($"{negativeResult:f6}");
        Console.WriteLine($"{zeroResult:f6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
