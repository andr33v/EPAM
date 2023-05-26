using System;
using System.Threading;

class Task1 : Task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Task I - GCD for three numbers.");

        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Greatest common divisor of {a}, {b} and {c} is {gcd(gcd(a, b), c)}");
        TaskII();
    }

    public static int gcd(int first, int second)
    {
        if(first == second)
        {
            return first;
        }

        while (first != second)
        {
            if (first > second)
            {
                first = first - second;
            }
            else
            {
                second = second - first;
            }
        }

        return first;
    }
}