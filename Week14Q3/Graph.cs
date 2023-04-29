using System;
public class Graph {
    int[,] adjacencyNodes;
    int numNodes;

    public Graph(int n) {
        numNodes = n;
        adjacencyNodes = new int[n, n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                adjacencyNodes[i, j] = 0;
            }
        }
    }

    public void AddEdge(int i, int j) {
        // if (i < 0 || j < 0 || i >= numNodes || j >= numNodes) {
        //     Console.WriteLine("Invalid input. Please enter non-negative integers less than {0}.", numNodes);
        //     return;
        // }
        adjacencyNodes[i, j] = 1;
    }

    public bool IsReachable(int i, int j) {
        bool[] visited = new bool[numNodes];
        for (int k = 0; k < numNodes; k++) {
            visited[k] = false;
        }
        return DFS(i, j, visited);
    }

    private bool DFS(int i, int j, bool[] visited) {
        visited[i] = true;
        if (i == j) {
            return true;
        }
        for (int k = 0; k < numNodes; k++) {
            if (adjacencyNodes[i, k] == 1 && !visited[k]) {
                if (DFS(k, j, visited)) {
                    return true;
                }
            }
        }
        return false;
    }
}