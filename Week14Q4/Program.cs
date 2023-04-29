using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter nodes : ");
        int n = int.Parse(Console.ReadLine());
        List<(int, int)> adjacencyNodes = new List<(int, int)>();
        int[] count = new int[n];
        for (int i = 0; i < n; i++) {
            count[i] = 0;
        }
        Console.WriteLine("Enter source node and destination node (number between 0 <-> {0})");
        while (true) {
            int i = int.Parse(Console.ReadLine());
            if (i < 0 || i >= n) {
                break;
            }

            int j = int.Parse(Console.ReadLine());
            if (j < 0 || j >= n) {
                break;
            }

            if (i == j) {
                Console.WriteLine("Invalid input: source and destination nodes must be different.");
                continue;
            }

            adjacencyNodes.Add((i, j));
        }

        // Change number to Symbol
        char[] symbols = new char[n];
        for (int i = 0; i < n; i++) {
            symbols[i] = (char)('A' + i);
        }

        foreach (var adjacencyNode in adjacencyNodes) {
            Console.WriteLine("{0} <-> {1}",adjacencyNode.Item1, adjacencyNode.Item2);
            for(int j =0 ; j < n; j++) {
                if(adjacencyNode.Item1 == j || adjacencyNode.Item2 == j) {
                    count[j]++;
                }
            }
        }
        for(int i = 0; i < n;i++) {
            Console.WriteLine("Node {0} : {1} line(s) ",symbols[i],count[i]);     
        }
        Array.Sort(count);
        Array.Reverse(count);
        Console.WriteLine("Minimum Node(s) : {0}",count[0]);
    }
}