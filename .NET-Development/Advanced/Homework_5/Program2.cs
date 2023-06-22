using System;
using System.Security.Cryptography;

class NumberSearchAlgorithms
{
    public static void NumberSearch()
    {
        Console.WriteLine("<------Number search algorithms------>");
        Console.WriteLine("Current array looks like: ");

        int[] arr = { 5, 8, 10, 13, 21, 23, 25, 43, 54, 75 };
        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }

        Console.Write("\n\nEnter some number to find: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nChoose an algorithm to find {num} in array:\n1 - Linear Search\n2 - Binary Search\n");

        short algorithm = Convert.ToInt16(Console.ReadLine());
        bool isFound = false;
        switch (algorithm)
        {
            case 1:
                isFound = LinearSearch(arr, num);
                break;
            case 2:
                isFound = BinarySearch(arr, num);
                break;
        }

        if (isFound)
        {
            Console.WriteLine($"Number {num} found in array!");
        }
        else
        {
            Console.WriteLine($"There is no {num} in array!");
        }
    }

    static bool LinearSearch(int[] nums, int num)
    {
        int moves = 0;
        foreach (int x in nums)
        {
            ++moves;
            if (x == num)
            {
                Console.WriteLine($"Number of moves: {moves}");
                return true;
            }
        }
        Console.WriteLine($"Number of moves: {moves}");
        return false;
    }

    static bool BinarySearch(int[] nums, int num)
    {
        Array.Sort(nums);
        int moves = 0;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            ++moves;
            int mid = (left + right) / 2;

            if (nums[mid] == num)
            {
                Console.WriteLine($"Number of moves: {moves}");
                return true;
            }
            else if (nums[mid] > num)
            {
                right = mid - 1;
                
            }
            else
            {
                left = mid + 1;
            }   
        }

        Console.WriteLine($"Number of moves: {moves}");
        return false;
    }
}