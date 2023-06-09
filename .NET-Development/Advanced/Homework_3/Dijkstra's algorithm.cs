using System;

class Dijkstra : Dijkstra_Enhanced
{
    static int[,] matrix = new int[6, 6]
    {
        { 0,  7,  9,  0, 0, 14},
        { 7,  0, 10, 15, 0,  0},
        { 9, 10,  0, 11, 0,  2},
        { 0, 15, 11,  0, 6,  0},
        { 0,  0,  0,  6, 0,  9},
        {14,  0,  2,  0, 9,  0},
    };

    static void matrixprint(int[,] matrix)
    {
        Console.WriteLine("Matrix: ");
        for(int i = 0; i < 6; ++i)
        {
            for(int j = 0; j < 6; ++j)
            {
                Console.Write("{0, 3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Dijkstras(int start, int n)
    {
        matrixprint(matrix);

        --start;

        int[] dist = new int[n];
        int[] parent = new int[n];
        bool[] processed = new bool[n];

        for(int i = 0; i < n; ++i)
        {
            dist[i] = int.MaxValue;
        }
        dist[start] = 0;
        int cur = start;
        parent[start] = start;

        while (!processed[cur])
        {
            processed[cur] = true;
            for(int j = 0; j < n; ++j)
            {
                if (matrix[cur, j] != 0)
                {
                    int d = dist[cur] + matrix[cur, j];
                    if(d < dist[j])
                    {
                        dist[j] = d;
                        parent[j] = cur;
                    }
                }
            }

            int min_dist = int.MaxValue;
            for(int k = 0; k < n; ++k)
            {
                if (!processed[k] && dist[k] < min_dist)
                {
                    cur = k;
                    min_dist = dist[k];
                }
            }
        }

        for(int i = 0; i < n; ++i)
        {
            Console.WriteLine($"Distance from top {start + 1} to {i + 1} equals {dist[i]}");
            int fin = i;
            Console.Write($"{fin + 1}");
            while (parent[fin] != start)
            {
                fin = parent[fin];
                Console.Write($" <= {fin + 1}");
            }
            Console.WriteLine($" <= {start + 1}");
        }
    }
}