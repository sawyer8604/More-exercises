﻿using System.CodeDom.Compiler;
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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {

        int firstResult = x1;
        int secondResult = x2;


        for (int i = 0; i < 10000; i++)
        {
            firstResult += v1;
            secondResult += v2;

            if (firstResult == secondResult)
            {
                return "YES";
            }

        }
        return "NO";

        //var result = "";

        //if (x1 < x2 && v1 < v2)
        //    result = "NO";

        //else if (x2 < x1 && v2 < v1)
        //    result = "NO";

        //else if (x2 < x1)
        //{
        //    //v2 > v1
        //    var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
        //    //check whether number of jumps is a whole number  i.e no fractional part.
        //    if (numberOfJumps % 1 == 0)
        //        result = "YES";
        //    else
        //        result = "NO";
        //}
        //else
        //{
        //    //v1 > v2
        //    var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
        //    //check whether number of jumps is a whole number  i.e no fractional part.
        //    if (numberOfJumps % 1 == 0)
        //        result = "YES";
        //    else
        //        result = "NO";
        //}
        //return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

       Console.WriteLine(result);

       // textWriter.Flush();
       // textWriter.Close();
    }
}
