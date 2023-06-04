using System;
class TaskIII
{
    public static void SortMethod()
    {
        //Task III: Build-in sort algorithm;
        Console.WriteLine("----------TASK_III----------");
        Console.Write(".NET-Sort simple pseudo-explain\n");
        Console.WriteLine("///press space key to continue\\\\\\\n");
        Console.ReadKey();

        Console.WriteLine("In short, Array.Sort algorithm uses custom\n" +
                          "'IntroSort' - that is a combination between\nQuickSort, HeapSort and InsertionSort\n");
        Console.ReadKey();

        Console.WriteLine("For Example, you can choose some size as you mind,\nbut when size >= 64 - this is some very BIG size of array\nsize <= 32 is some max depth for the recursion.\nsize <= 16 is some small amount of elements\n");
        Console.ReadKey();

        Console.Write("Enter size of 'array': ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Firsly we need to look at size of our array - {size}");
        Console.Write("We divide our array on segments: ");
        Console.ReadKey();
        while (size > 0)
        {
            Console.Write($"\n{size} - ");
            if(size <= 16)
            {
                Console.ReadKey();
                Console.Write("As we can see, size of current array so small, that the fastest algorithm here is some simple, like InsertionSort\n");
                size /= 16;
            }
            else if(size <= 32)
            {
                Console.ReadKey();
                Console.Write("Now our size is in range of recursion,\nbut still so high to use simple solution,\nwe decide efficient algorithm: QuickSort - divide array to smaller segments and recursively sort them\n");
            }
            else
            {
                Console.ReadKey();
                Console.Write("Current size of array is out of bounce, and may cause very long time-complexity,\nwe need some efficient sorting algorithm, like\nHeapSort - that builds 'pyramid' binary data structure and doesn't rely on recursion\n");
                if(size > 64)
                {
                    Console.WriteLine("I'll skip for you some iterations of dividing on segements...");
                    size = 64;
                    Console.ReadKey();
                }
            }
            size /= 2;
        }
        Console.WriteLine("\nSorted array!");

        //Information from https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-8.0 and build-in Array.Sort
    }
}