using System;
class Program : Program2
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Введіть число від якого потрібно почати зменшення");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть число до якого потрібно зменшувати");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Стовпчик усіх чисел від першого до другого включно: ");
        while(a >= b) 
        {
            Console.WriteLine(a--);
        }
        sumDigits();
    }
}