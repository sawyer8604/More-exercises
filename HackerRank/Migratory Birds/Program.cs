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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birds = new Dictionary<int, int>();

        for (int i = 0; i < arr.Count; i++)
        {
            int crrElement = arr[i];

            if (!birds.ContainsKey(crrElement))
            {
                birds[crrElement] = 0;
            }

            birds[crrElement]++;
        }

        var idOfTheMostFrequentlySightedType =
            birds
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .FirstOrDefault().Key;

        return idOfTheMostFrequentlySightedType;

            
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.WriteLine(result);

       // textWriter.Flush();
       // textWriter.Close();
    }
}
