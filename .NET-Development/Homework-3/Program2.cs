using System;

public class Program2
{
	public static void sumDigits()
	{
		int num, sum = 0;
		Console.Write("Введіть число з якого потрібно знайти суму цифр: ");
		num = Convert.ToInt32(Console.ReadLine());
		int save = num;
		while (num > 0)
		{
			sum += num % 10;
			num /= 10;
		}
		Console.WriteLine($"Сума цифр числа {save} дорівнює {sum}");
	}
}
