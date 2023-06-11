class Floyd_Warshall
{
    public static void Floyd_Warshalls(int n, int[,] matrix)
    {
        for (int k = 0; k < n; ++k)
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (matrix[i, k] != 0 && matrix[k, j] != 0)
                    {
                        int[] dist = Dijkstras(i, n, matrix);
                        int newDistance = dist[k] + matrix[k, j];
                        if (newDistance < matrix[i, j])
                        {
                            matrix[i, j] = newDistance;
                        }
                    }
                }
            }
        }
    }

    private static int[] Dijkstras(int start, int n, int[,] matrix)
    {
        int[] dist = new int[n];
        int[] parent = new int[n];
        bool[] processed = new bool[n];

        for (int i = 0; i < n; ++i)
        {
            dist[i] = int.MaxValue;
        }
        dist[start] = 0;
        int cur = start;
        parent[start] = start;

        while (!processed[cur])
        {
            processed[cur] = true;
            for (int j = 0; j < n; ++j)
            {
                if (matrix[cur, j] != 0)
                {
                    int d = dist[cur] + matrix[cur, j];
                    if (d < dist[j])
                    {
                        dist[j] = d;
                        parent[j] = cur;
                    }
                }
            }

            int min_dist = int.MaxValue;
            for (int k = 0; k < n; ++k)
            {
                if (!processed[k] && dist[k] < min_dist)
                {
                    cur = k;
                    min_dist = dist[k];
                }
            }
        }

        return dist;
    }
}