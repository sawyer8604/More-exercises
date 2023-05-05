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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int maxSum = int.MinValue;   

        for (int row = 0; row < arr.Count - 2; row++)
        {

            for (int col = 0; col < arr.Count - 2; col++)
            {
                int sum = 0;

                int firstRowfirstNum = arr[row][col];
                int firstRowsecondNum = arr[row][col + 1];
                int firstRowthirdNum = arr[row][col + 2];

                int secondRowNumber = arr[row + 1][col + 1];

                int thirdRowFirstNum = arr[row + 2][col];
                int thirdRowSecondNum = arr[row + 2][col + 1];
                int thirdRowThirdNum = arr[row + 2][col + 2];


                sum += firstRowfirstNum + firstRowsecondNum + firstRowthirdNum
                    + secondRowNumber
                    + thirdRowFirstNum + thirdRowSecondNum + thirdRowThirdNum;


                if (sum > maxSum)
                {    
                    maxSum = sum;
                }
            }
        }

        return maxSum;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
