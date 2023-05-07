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
     * Complete the 'CompareSums' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY input as parameter.
     */

    public static int CompareSums(List<int> input)
    {
        List<int> sums = new List<int>();

        for (int i = 0; i < input.Count - 2; i++)
        {
            int crrSum = 0;

            for (int j = i; j < i + 3; j++)
            {
                crrSum += input[j];

            }

            sums.Add(crrSum);
        }

        int counter = 0;

        for (int i = 0; i < sums.Count - 1; i++)
        {
            if (sums[i] < sums[i + 1])
            {
                counter++;
            }

        }

        return counter;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int inputCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> input = new List<int>();

        for (int i = 0; i < inputCount; i++)
        {
            int inputItem = Convert.ToInt32(Console.ReadLine().Trim());
            input.Add(inputItem);
        }

        int result = Result.CompareSums(input);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
