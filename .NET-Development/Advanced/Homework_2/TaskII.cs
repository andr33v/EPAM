using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Net.Http.Headers;

class TaskII : TaskIII
{
    public static void EfficientAlgorithms()
    {
        //Task II: Efficient sort algorithms
        Console.WriteLine("----------TASK_II----------");
        Console.Write("Enter number of elements in array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine($"Enter {size} elements: ");
        for (int i = 0; i < size; ++i)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Choose some algorithm for sorting:\n1 - QuickSort\n2 - ShellSort\n3 - HeapSort (Pyramid)\n4 - MergeSort\n");
        int v = Convert.ToInt16(Console.ReadLine());
        string arr = "";
        switch (v)
        {
            case 1:
                QuickSort(array, 0, size - 1);
                arr = "QuickSort";
                break;
            case 2:
                ShellSort(array, size);
                arr = "ShellSort";
                break;
            case 3:
                PyramidSort(array, size);
                arr = "HeapSort";
                break;
            case 4:
                MergeSort(array);
                arr = "MergeSort";
                break;
            default:
                Console.WriteLine("Wrong digit, try again!");
                arr = "UndefinedSort";
                break;
        }

        Console.WriteLine($"Sorting by {arr}: {DisplayArr(array, size)}\n");
        SortMethod();
    }

    static string DisplayArr(int[] arr, int sz)
    {
        string array = "";
        for(int i = 0; i < sz; ++i)
        {
            array += Convert.ToString(arr[i]) + ' ';
        }
        return array;
    }

    // Quick sort
    static void QuickSort(int[] arr, int start, int end)
    {
        if(start < end)
        {
            int pivot = Partition(arr, start, end);
            QuickSort(arr, start, pivot);
            QuickSort(arr, pivot + 1, end);
        }

    }

    static int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[start];
        int i = start - 1;
        int j = end + 1;

        while (true)
        {
            do
            {
                i++;
            } while (arr[i] < pivot);

            do
            {
                j--;
            } while (arr[j] > pivot);

            if (i >= j)
            {
                return j;
            }

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    //Shell's sort
    static void ShellSort(int[] arr, int size)
    {
        int gap = size / 2;
        while(gap > 0)
        {
            for(int i = gap; i < size; ++i)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }
            gap /= 2;
        }
    }

    //Pyramid (Heap) sort 
    static void PyramidSort(int[] arr, int size)
    {
        for(int i = size / 2 - 1; i >= 0; --i)
        {
            Heapify(arr, size, i);
        }

        for(int i = size - 1; i > 0; --i)
        {
            int temp = arr[i];
            arr[i] = arr[0];
            arr[0] = temp;

            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int root)
    {
        int max = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;

        if(left < n && arr[left] > arr[max])
        {
            max = left;
        }

        if(right < n && arr[right] > arr[max])
        {
            max = right;
        }

        if(max != root)
        {
            int temp = arr[root];
            arr[root] = arr[max];
            arr[max] = temp;

            Heapify(arr, n, max);
        }
    }

    //Merge sort
    static void MergeSort(int[] arr)
    {
        if(arr.Length == 1)
        {
            return;
        }

        int n = arr.Length;
        int mid = n / 2;

        int[] leftArr = new int[mid];
        int[] rightArr = new int[n - mid];

        for(int i = 0; i < mid; ++i)
        {
            leftArr[i] = arr[i];
        }

        for(int i = mid; i < n; ++i)
        {
            rightArr[i - mid] = arr[i];
        }

        MergeSort(leftArr);
        MergeSort(rightArr);

        Merge(arr, leftArr, rightArr);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int leftIdx = 0, rightIdx = 0, midIdx = 0;

        while(leftIdx < left.Length && rightIdx < right.Length) 
        {
            if (left[leftIdx] <= right[rightIdx])
            {
                arr[midIdx] = left[leftIdx];
                ++leftIdx;
            }
            else
            {
                arr[midIdx] = right[rightIdx];
                ++rightIdx;
            }
            ++midIdx;
        }

        while(leftIdx < left.Length)
        {
            arr[midIdx] = left[leftIdx];
            ++leftIdx;
            ++midIdx;
        }

        while(rightIdx < right.Length)
        {
            arr[midIdx] = right[rightIdx];
            ++rightIdx;
            ++midIdx;
        }
    }
}