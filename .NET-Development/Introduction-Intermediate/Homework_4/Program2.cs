using System;

public class Program2 : Program3
{
    public static void Task2()
    {
        //Завдання #2
        Console.WriteLine("Програма для обчислення суми максимального та мінімального елементів двовимірного масиву.");

        Console.WriteLine("Введіть кількість рядків двовимірного масиву: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть кількість стовпчиків двовимірного масиву: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[rows, cols];

        Console.WriteLine($"Введіть {rows * cols} чисел: ");
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int min = arr[0, 0];
        int max = min;

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"Мінімальне число цього масиву: {min} а максимальне: {max}, а їхня сума: {min + max}");
        //Перехід до задачі #3
        Console.WriteLine();
        Task3();
    }
}
