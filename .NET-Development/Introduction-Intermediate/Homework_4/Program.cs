using System;
class Program : Program2
{
    static void Main(string[] args)
    {
        //Підтримка українських символів
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Завдання #1
        Console.WriteLine("Програма для обчислення суми додатних та кількості парних елементів: ");
        int sum = 0;
        int count = 0;

        Console.Write("Введіть розмір масиву: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine($"Введіть {size} чисел: ");
        for (int i = 0; i < size; ++i)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int j = 0; j < size; ++j)
        {
            if (arr[j] > 0)
            {
                sum += arr[j];
            }
            if (arr[j] % 2 == 0)
            {
                ++count;
            }
        }

        Console.WriteLine($"Сума додатних чисел введеного масиву: {sum} а кількість парних елементів: {count}");

        //Перехід до задачі #2
        Console.WriteLine();
        Task2();
    }
}