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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
       const int Days = 256;

        int months = 256 / 30;

        int[] normalYear = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int[] leapYear = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int realMonths = 1;
        int crrdays = 0;  

        for (int i = 0; i < months; i++)
        {
            realMonths++;
            
            if (year % 4 == 0)
            {
                crrdays += leapYear[i];
            }
            else
            {
                crrdays += normalYear[i];
            }
        }
        int realDays = 256 - crrdays;

        string searchedDate = $"{realDays}.{realMonths:d2}.{year}";

        DateTime dateTime = DateTime.Parse(searchedDate);

        return dateTime.ToString("dd.mm.yyyy");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
