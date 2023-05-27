using System;
class Task2
{
    public static void TaskII()
    {
        Console.WriteLine("Task II - The closest prime number to target.");

        Console.Write("Enter target number: ");
        long n = Convert.ToInt64(Console.ReadLine());

        long curr = 0;
        long prev = 0;
        long result = 2;
        bool isPrime;
        bool isNum = false;

        for (long j = 2; j <= n * n; ++j)
        {
            if (!isNum)
            {
                prev = curr;
            }

            isPrime = true;

            for (long i = 2; i * i <= j; ++i)
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
                    long min = Math.Abs(n - curr);
                    long max = n - prev;

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