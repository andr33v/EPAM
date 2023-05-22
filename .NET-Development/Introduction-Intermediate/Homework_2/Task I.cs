using System;

public class Program : Program_2
{
    public static void Main()
    {
        Console.WriteLine("Скільки гривень має Петрик?");
        double s = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Скільки коштує один зошит?");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Скільки коштує одна ручка?");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Скільки зошитів вам потрібно?");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Скільки ручок вам потрібно?");
        int m = Convert.ToInt32(Console.ReadLine());

        double sum = x * n + y * m;
        Console.Write("Петрик має {0} гривень, а бажані товари коштують {1} гривень, тому ", s, sum);

        if (s >= sum)
        {
            Console.WriteLine("Петрик може здійснити покупку, а в залишку отримає {0} гривень", s - sum);
        }
        else
        {
            Console.WriteLine("Петрик не може здійснити покупку, йому не вистачає {0} гривень", sum - s);
        }

        Main2();
    }
}