class Dijkstra_Enhanced : Floyd_Warshall
{
    public static void Dijkstras_PQ(int start, int n, int[,] matrix)
    {
        --start;

        int[] dist = new int[n];
        int[] parent = new int[n];
        bool[] processed = new bool[n];

        for(int i = 0; i < n; ++i)
        {
            dist[i] = int.MaxValue;
        }
        dist[start] = 0;
        parent[start] = start;

        PriorityQueue<int> queue = new PriorityQueue<int>();

        queue.Enqueue(start, 0);

        while(queue.Count > 0)
        {
            int cur = queue.Dequeue();

            if (processed[cur])
            {
                continue;
            }

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

                        queue.Enqueue(j, d);
                    }
                }
            }
        }

        for(int i = 0; i < n; ++i)
        {
            Console.WriteLine($"Distance from top {start + 1} to {i + 1} equals {dist[i]}");
            int fin = i;
            Console.Write(fin + 1);
            while (parent[fin] != start)
            {
                fin = parent[fin];
                Console.Write($" <= {fin + 1}");
            }
            Console.WriteLine($" <= {start + 1}");
        }
    }
}

//priority_queue
class PriorityQueue<T>
{
    SortedDictionary<int, Queue<T>> queue;

    public int Count { get; set; }

    public PriorityQueue()
    {
        queue = new SortedDictionary<int, Queue<T>>();
        Count = 0;
    }

    public void Enqueue(T item, int priotity)
    {
        if(!queue.TryGetValue(priotity, out var priorityQueue))
        {
            priorityQueue = new Queue<T>();
            queue.Add(priotity, priorityQueue);
        }

        priorityQueue.Enqueue(item);
        ++Count;
    }

    public T Dequeue()
    {
        if(Count == 0)
        {
            throw new InvalidOperationException("Priority Queue is empty.");
        }

        var minPriorityQueue = queue.First();
        var item = minPriorityQueue.Value.Dequeue();
        --Count;

        if(minPriorityQueue.Value.Count == 0)
        {
            queue.Remove(minPriorityQueue.Key);
        }

        return item;
    }
}