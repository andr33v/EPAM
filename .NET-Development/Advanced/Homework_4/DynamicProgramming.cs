using System;
using System.Collections.Generic;

class DynamicProgramming
{
    static void Main(string[] args)
    {
        List<string> dp = new List<string>();
        Console.Write("Enter length of number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDo you want to use recursion or iterative approach?\n1 - Recursion\n0 - Iteration");

        bool isRec = Console.ReadLine() == "1";
        if (isRec)
            dpRecursive(dp, "", n, false);
        else
            dpIterative(dp, n);

        Console.WriteLine($"\nIf number length equals {n}, there are {dp.Count} combinations of 0 and 1, where 1 doesn't goes twice.");
        Console.WriteLine("Do you like to see these combinations?\n1 - Yes\n0 - No");

        bool showDp = Console.ReadLine() == "1";
        if(showDp)
        {
            Console.WriteLine("\nList of combinations: ");
            foreach (string s in dp)
            {
                Console.WriteLine(s);
            }
        }

        Console.WriteLine("\nThanks for testing!");
    }

    static void dpIterative(List<string> dp, int len)
    {
        dp.Add("0");
        dp.Add("1");

        for(int i = 2; i <= len; ++i)
        {
            int size = dp.Count;

            for(int j = 0; j < size; ++j)
            {
                string temp = dp[j];
                dp[j] += '0';

                if (temp[temp.Length - 1] == '0')
                {
                    dp.Add(temp + '1');
                }
            }
        }
    }

    static void dpRecursive(List<string> dp, string cur, int rem, bool prev)
    {
        if (rem == 0)
        {
            dp.Add(cur);
        }
        else
        {
            dpRecursive(dp, cur + '0', rem - 1, false);
            if (prev == false)
            {
                dpRecursive(dp, cur + '1', rem - 1, true);
            }
        }
    }
}