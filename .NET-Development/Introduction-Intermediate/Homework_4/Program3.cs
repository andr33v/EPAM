using System;

public class Program3
{
    public static void Task3()
    {
        //Завдання #3 *
        Console.WriteLine("Програма для знаходження найменшого номера рядка двохвимірного масиву з найбільшою сумою елементів.");

        Console.WriteLine("Введіть кількість рядків двохвимірного масиву: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть кількість стовпчиків двохвимірного масиву: ");
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

        int sum = 0;
        int temp = 0;
        int index = 0;
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                temp += arr[i, j];
            }
            if (temp > sum || i == 0)
            {
                sum = temp;
                index = i;
            }
            temp = 0;
        }

        Console.WriteLine($"Найменший рядок у якого найбільша сума чисел має індекс: {index}, а його сума дорівнює: {sum}");
    }
}