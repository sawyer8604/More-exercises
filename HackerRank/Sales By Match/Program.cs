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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> pairsOfSocks = new Dictionary<int, int>();

        for (int i = 0; i < ar.Count; i++)
        {
            int crrElement = ar[i];

            if(!pairsOfSocks.ContainsKey(crrElement))
            {
                pairsOfSocks[crrElement] = 0;
            }

            pairsOfSocks[crrElement]++;
        }

        int countOfPairsOfSocks = 0;

        foreach (var sock in pairsOfSocks)
        {
            countOfPairsOfSocks += sock.Value / 2;
        }

        return countOfPairsOfSocks;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
