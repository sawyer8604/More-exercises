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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int minNumber = scores[0];
        int maxNumber = scores[0];

        int minScoreCount = 0;
        int maxScoreCount = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            int crrMinNumber = scores[i];
            int crrMaxNumber = scores[i];

            if(crrMinNumber < minNumber)
            {
                minNumber = crrMinNumber;
                minScoreCount++;
            }

            if(crrMaxNumber > maxNumber)
            {
                maxNumber = crrMaxNumber;
                maxScoreCount++;
            }
        }

        List<int> result = new List<int>();
        result.Add(maxScoreCount);
        result.Add(minScoreCount);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
