using System;
public class Program {
    public static void Main(string[] args) {
        Console.Write("Enter nodes (int) : ");
        int n = int.Parse(Console.ReadLine());
        Graph graph = new Graph(n);
        int i = 0, j = 0;
        while (i >= 0 && i < n && j >= 0 && j < n) {
            Console.Write("Enter source node (i) : ");
            i = int.Parse(Console.ReadLine());
            if (i < 0 || i >= n) {
                //throw new Exception("do not enter 0 > i <= n ");
                break;
            }
            Console.Write("Enter destination node (j) : ");
            j = int.Parse(Console.ReadLine());
            if (j < 0 || j >= n) {
                //throw new Exception("do not enter 0 > j <= n ");
                break;
            }
            graph.AddEdge(i, j);
        }
        Console.Write("Enter source node to check (i-check) : ");
        int icheck = int.Parse(Console.ReadLine());
        Console.Write("Enter destination node to check (j-check) : ");
        int jcheck = int.Parse(Console.ReadLine());
        if (graph.IsReachable(icheck, jcheck)) {
            Console.WriteLine("Reachable");
        } else {
            Console.WriteLine("Unreachable");
        }
    }
}