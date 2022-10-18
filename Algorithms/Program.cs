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

class Program
{
    public static void Main(string[] args)
    {

        var list = new List<int>()
        {
            1, 2, 3, 4,5
        };
        Console.WriteLine(SimpleArraySum(list));

        var a = new List<int>() { 5, 6, 7 };
        var b = new List<int>() { 3, 6, 10 };
        Console.WriteLine(CompareTriplets(a, b).ToString());
        var list1 = new List<List<int>>()
        {
           new List<int>() { 1, 2, 3 },
           new List<int>() { 4,5,6 },
           new List<int>() { 7,8,9 }
        };
        Console.WriteLine(DiagonalDifference(list1));
        PlusMinus(list);
    }
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int SimpleArraySum(List<int> ar)
    {

        return ar.Sum();

    }
    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>() { 0, 0 };
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                result[0] += 1;
            }
            else if (a[i] < b[i])
            {
                result[1] += 1;
            }
        }
        return result;
    }

    public static int DiagonalDifference(List<List<int>> arr)
    {
        int tot1 = 0;
        int tot2 = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                {
                    tot1 += arr[i][j];
                }
                if (i + j == arr.Count - 1)
                {
                    tot2 += arr[i][j];
                }
            }
        }
        return Math.Abs(tot1 - tot2);

    }
    public static void PlusMinus(List<int> arr)
    {
        double tot = arr.Count;
        double minus = 0;
        double zero = 0;
        double plus = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < 0)
            {
                minus += 1;
            }
            else if (arr[i] == 0)
            {
                zero += 1;
            }
            else
            {
                plus += 1;
            }
        }
        Console.WriteLine(plus / tot);
        Console.WriteLine(minus / tot);
        Console.WriteLine(zero / tot);
    }
    public static void miniMaxSum(List<int> arr)
    {
        string minArr = (arr.Sum() - arr.Max()).ToString();
        string maxArr = (arr.Sum() - arr.Min()).ToString();
        Console.WriteLine(minArr + " " + maxArr);
    }
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> gradesRound = new List<int>();
        for (int i = 0; i < grades.Count; i++)
        {
            double x = grades[i] / 10;
            int y = grades[i] / 10;
            double tot = x - y;
            tot = tot * 10;
            int tot1 = Convert.ToInt32(tot) + y;
            gradesRound.Add(tot1);
        }
        
        return gradesRound;

    }
}



