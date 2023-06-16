using System;
using System.Collections.Generic;
class NewDynamicProgramming
{
    static void Main(string[] args)
    {
        Console.Write("Enter a length of the number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> dp = new List<int>(5);
        dp.Add(2); // 0 and 1
        dp.Add(3); // 00, 01, 10

        for(int i = 2; i < n; ++i)
        {
            dp.Add(dp[i - 2] + dp[i - 1]);
        }

        Console.WriteLine($"The number of combinations equals: {dp[n - 1]}");
    }
}