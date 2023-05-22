using System;
class Program
{
    public static void Main(string[] args)
    {
        //Task 1
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        AvgOfTwoNums(a, b);

        //Task 2
        Console.Write("Enter number of integer elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Enter {n} integers: ");
        for (int i = 0; i < n; ++i)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"The maximum element in your array is {MaxArrayElement(n, arr)}");

        //Task 3
        Console.Write("Enter amount of rows in array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter amount of columns in array: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] mat = new int[rows, cols];
        Console.WriteLine($"Enter {rows * cols} elements: ");
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        MatHorShift(rows, cols, mat);
    }

    public static void AvgOfTwoNums(int a, int b)
    {
        Console.WriteLine($"Arithmetic average of two integers {a} and {b} equals {(a + b) / 2.0}");
    }

    public static int MaxArrayElement(int n, int[] arr)
    {
        int max = arr[0];
        for(int i = 1; i < n; ++i)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    public static void MatHorShift(int rows, int cols, int[,] mat)
    {
        int[,] temp = new int[rows, cols];
        for(int i = 0; i < cols; ++i)
        {
            temp[0, i] = mat[rows - 1, i];
        }
        for(int i = 0; i < rows - 1; ++i)
        {
            for(int j = 0; j < cols; ++j)
            {
                temp[i + 1, j] = mat[i, j];
            }
        }

        Console.WriteLine("New array with horizontal shift looks like: ");
        for(int r = 0; r < rows; ++r)
        {
            for(int c = 0; c < cols; ++c)
            {
                Console.Write($"{temp[r, c]} ");
            }
            Console.WriteLine();
        }

    }
}