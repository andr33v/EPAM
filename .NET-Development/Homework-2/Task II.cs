using System;

public class Program_2
{
    public static void Main2()
    {
        Console.Write("Введіть будь-яке тризначне число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int numSave = num;

        int temp, res = 0;

        List<int> max = new List<int>();

        do {
            temp = num % 10;
            num /= 10;
            max.Add(temp);
        
        }while (num > 0);

        max.Sort();
        max.Reverse();

        foreach (int i in max)
        {
            res += i;
            res = res < 100 ? res *= 10 : res *= 1;
        }

        Console.WriteLine("Найбільше число, яке можна отримати з {0} це {1}", numSave, res);
    }
}