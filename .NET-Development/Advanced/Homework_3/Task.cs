class Graph : Dijkstra
{
    static int[,] matrix =
    {
        { 0, 3, 9999, 7 },
        { 8, 0, 2, 9999 },
        { 5, 9999, 0, 1 },
        { 2, 9999, 9999, 0 }
    };

    static int size = matrix.GetLength(0);

    static void Main(string[] args)
    {
        //Task - Dijkstra's and Floyd-Warshall's algorithms
        matrixprint(matrix);

        Console.WriteLine("\nChoose an algorithm for current matrix:\n1 - Dijkstra's\n2 - Enhanced Dijkstra's\n3 - Floyd Warshall's\n");
        int start, choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("\nDijkstra Classic - O(V^2)");
                Console.Write("Enter the number of starting vertex: ");
                start = Convert.ToInt32(Console.ReadLine());
                Dijkstras(start, size, matrix);
                break;
            case 2:
                Console.WriteLine("\nDijkstra Priority Queue - O((V + E) log V)");
                Console.Write("Enter the number of starting vertex: ");
                start = Convert.ToInt32(Console.ReadLine());
                Dijkstras_PQ(start, size, matrix);
                break;
            case 3:
                Console.WriteLine("\nFloyd-Warshall + Dijkstra - O(V^3)");
                Floyd_Warshalls(size, matrix);
                matrixprint(matrix);
                break;      
        }
    }

    static void matrixprint(int[,] matrix)
    {
        Console.WriteLine("Current matrix: ");
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                if (matrix[i, j] == 9999)
                {
                    Console.Write("{0, 4}", "INF");
                }
                else
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}