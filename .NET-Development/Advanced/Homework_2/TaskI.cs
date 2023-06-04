using System;
using System.Collections.Generic;
class TaskI : TaskII
{
    static void Main(string[] args)
    {
        //Task I: Compare simple-sort algorithms
        Console.WriteLine("----------TASK_I----------");
        Console.Write("Enter number of elements in array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine($"Enter {size} elements: ");
        for(int i = 0; i < size; ++i)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Current array: {DisplayArray(array)}\n");
        int[] arr = new int[size];
        (string f, int s) bubble = ("", 0);
        (string f, int s) selection = ("", 0);
        (string f, int s) insertion = ("", 0);

        for (int i = 0; i < 3; ++i)
        {
            if (i == 0)
            {
                Array.Copy(array, arr, size);
                bubble = ("BubbleSort", BubbleSort(arr));
            }
            else if (i == 1)
            {
                Array.Copy(array, arr, size);
                selection = ("SelectionSort", SelectionSort(arr));
            }
            else
            {
                Array.Copy(array, arr, size);
                insertion = ("InsertionSort", InsertionSort(arr));
            }
        }
        Console.Write($"The best algorithm at current array is ");
        if(bubble.s < selection.s && bubble.s < insertion.s)
        {
            Console.WriteLine(bubble.f);
        }
        else if (selection.s < bubble.s && selection.s < insertion.s)
        {
            Console.WriteLine(selection.f);
        }
        else if (insertion.s < bubble.s && insertion.s < selection.s)
        {
            Console.WriteLine(insertion.f);
        }
        else
        {
            Console.WriteLine("any of them");
        }
        Console.WriteLine($"\nSorted array: {DisplayArray(arr)}");

        EfficientAlgorithms();
    }

    static string DisplayArray(int[] array)
    {
        string arr = "";
        for(int i = 0; i < array.Length; ++i)
        {
            arr += Convert.ToString(array[i]) + ' ';
        }
        return arr;
    }

    static int BubbleSort(int[] arr)
    {
        int compares = 0;
        int changes = 0;
        for(int i = 0; i < arr.Length - 1; ++i)
        {
            for(int j = i + 1; j < arr.Length; ++j)
            {
                ++compares;
                if (arr[j] < arr[i])
                {
                    ++changes;
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        Console.WriteLine($"Bubble Sort - compares: {compares}, changes {changes}");
        return compares + changes;
    }

    static int SelectionSort(int[] arr)
    {
        int compares = 0;
        int changes = 0;
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            int min = i;
            for(int j = i + 1; j < arr.Length; ++j)
            {
                ++compares;
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            ++changes;
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        Console.WriteLine($"Selection Sort - compares: {compares}, changes {changes}");
        return compares + changes;
    }

    static int InsertionSort(int[] arr)
    {
        int compares = 0;
        int changes = 0;
        bool isComp = false;
        for (int i = 1; i < arr.Length; ++i)
        {
            int temp = arr[i];
            int j;
            ++compares;
            for (j = i - 1; j >= 0 && arr[j] > temp; --j)
            {
                if (isComp)
                {
                    ++compares;
                }
                isComp = true;
                arr[j + 1] = arr[j];
                ++changes;
            }
            isComp = false;
            arr[j + 1] = temp;
        }
        Console.WriteLine($"Insertion Sort - compares: {compares}, changes {changes}");
        return compares + changes;
    }
}