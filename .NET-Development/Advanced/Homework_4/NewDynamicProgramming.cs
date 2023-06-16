using System;
using System.Collections.Generic;
class NewDynamicProgramming
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dynamic Programming - Number of combinations of 0 and 1, where 1 isn't repeated twice.");
        Console.Write("Enter a length of the number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n == 0)
        {
            Console.WriteLine("There are no combinations at this length!");
        }

        List<int> dp = new List<int>(n);
        dp.Add(2); // 0 and 1
        dp.Add(3); // 00, 01, 10

        for(int i = 2; i < n; ++i)
        {
            dp.Add(dp[i - 2] + dp[i - 1]);
        }

        Console.WriteLine($"The number of combinations at length {n} equals: {dp[n - 1]}");
    }
}