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
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        /*****
            Example:
            aba
            10
        ******/
        var chars = s.ToCharArray(); // Setting the string to char array
        var multiple = (n / s.Length) * s.Length; // 10/3 * 3 == 9
        var last = n - multiple; // 10-9 == 1
        var writtenTimes = multiple / s.Length; // 9/3 == 3
        var aFound = writtenTimes * chars.Count(x => x == 'a'); // chars search found two 'a' so 3*2 == 6

        // Then we loop through the last batch (if any) and see if there is an 'a' in that
        for (int i = 0; i < last; i++)
        {
            if (chars[i] == 'a')
            {
                aFound++;
            }
        }
        return aFound;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
