using System.Collections.Immutable;

class SearchStringAlgorithms : NumberSearchAlgorithms
{
    static void Main()
    {
        Console.WriteLine("<------String search algorithms------>");
        string str = "ABCABCAABCABD";
        Console.Write($"Current string equals:\n{str}\n\nEnter some substr to find: ");

        string? substr = Convert.ToString(Console.ReadLine()) ?? string.Empty;
        bool isSubstr = false;
        if (str.Length >= substr.Length && substr != "")
        {
            Console.WriteLine($"\nChoose an algorithm to find {substr} in string:");
            Console.WriteLine("1 - Linear Search\n2 - Knuth-Morris-Pratt (KMP) algorithm\n");

            short algorithm = Convert.ToInt16(Console.ReadLine());
            switch (algorithm)
            {
                case 1:
                    Console.WriteLine("\nLinear Search: ");
                    isSubstr = LinearSearch(str, substr);
                    break;

                case 2:
                    Console.WriteLine("\nKMP: ");
                    isSubstr = KMP(str, substr);
                    break;
            }
        }

        if (isSubstr)
        {
            Console.WriteLine($"Substr {substr} exists in current string!\n");
        }
        else
        {
            Console.WriteLine($"There is no {substr} in current string!\n");
        }

        NumberSearch();
    }

    static bool LinearSearch(string str, string substr)
    {
        int moves = 0;
        for (int i = 0; i < str.Length; ++i)
        {
            int curI = i;
            for (int j = 0; j < substr.Length; ++j)
            {
                ++moves;
                if (str[curI++] == substr[j])
                {
                    if (j == substr.Length - 1)
                    {
                        ShowPosition(i, str, moves);
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        return false;
    }

    static bool KMP(string str, string substr)
    {
        int[] prefix = PrefixTable(substr); 

        int i = 0;
        int j = 0;
        int moves = 0;

        while (i < str.Length)
        {
            if (str[i] == substr[j])
            {
                if (j == substr.Length - 1)
                {
                    ShowPosition(i - j, str, moves);
                    return true;
                }

                i++;
                j++;
                ++moves;
            }
            else if (j > 0)
            {
                j = prefix[j - 1];
                ++moves;
            }
            else
            {
                i++;
                ++moves;
            }
        }
        
        return false;
    }

    static int[] PrefixTable(string substr)
    {
        int n = substr.Length;
        int[] prefixTable = new int[n];
        int length = 0;

        int i = 1;
        while(i < n)
        {
            if (substr[i] == substr[n - 1])
            {
                length++;
                prefixTable[i] = length;
                ++i;
            }
            else
            {
                if(length != 0)
                {
                    length = prefixTable[length - 1];
                }
                else
                {
                    prefixTable[i] = 0;
                    ++i;
                }
            }
        }

        return prefixTable;
    }

    static void ShowPosition(int pos, string str, int moves)
    {
        Console.WriteLine($"Number of moves to find: {moves}\n");

        for (int k = 0; k < str.Length; ++k)
        {
            Console.Write(str[k] + " ");
            if (k >= 10) Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 0; i < str.Length; ++i)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < pos * 2; ++j)
        {
            Console.Write(" ");
            if (j > 20) Console.Write(" ");
        }
        Console.WriteLine("^");
    }
}