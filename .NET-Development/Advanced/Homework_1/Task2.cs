using System;
class Task2
{
    public static void TaskII()
    {
        Console.WriteLine("Task II - The closest prime number to target.");

        Console.Write("Enter target number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int curr = 0;
        int prev = 0;
        int result = 0;
        bool isPrime;
        bool isNum = false;

        for (int j = 2; j <= n * n; ++j)
        {
            if (!isNum)
            {
                prev = curr;
            }

            isPrime = true;

            for (int i = 2; i * i <= j; ++i)
            {
                if (j % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime)
            {
                curr = j;

                if (curr == n)
                {
                    isNum = true;
                }

                if ( curr > n && prev < n )
                {
                    int min = Math.Abs(n - curr);
                    int max = n - prev;

                    if( max >= min )
                    {
                        result = curr;
                    }
                    else
                    {
                        result = prev;
                    }

                    break;
                } 
            }
        }

        Console.Write($"The closest prime number to {n} is ");
        if (isNum) Console.Write("the number itself and ");
        Console.Write(result);
    }
}