﻿using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Скільки коштує один зошит?");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Скільки коштує одна ручка?");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Скільки зошитів вам потрібно?");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Скільки ручок вам потрібно?");
        int m = Convert.ToInt32(Console.ReadLine());

        double sum = x * n + y * m;
        Console.WriteLine("Загальна сума: {0}", sum);
    }
}