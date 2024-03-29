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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int result = 0;
        int countUp = 0;
        int countDown = 0;

        int valleyCount = 0;
        bool isInValey = true;

        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'U')
            {
                result++;
                countUp++;
               
            }
            else
            {
                result--;
                countDown++;
                
                if(isInValey)
                {
                    valleyCount++;
                }
            }

            if(countUp - countDown == 0)
            {
                isInValey = true;
            }
            else
            {
                isInValey = false;
            }
            

            if(countDown > countUp && result < 0 && isInValey == true)
            {
                valleyCount++;
            }
        }

        return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);

        //textWriter.Flush();
       // textWriter.Close();
    }
}
