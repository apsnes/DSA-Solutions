// DFS
public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new List<int>();
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        var seen = new bool[n];
        if (Dfs(source, graph, seen, destination)) return true;

        return false;
    }

    private bool Dfs(int currNode, List<int>[] graph, bool[] seen, int target)
    {
        if (currNode == target) return true;
        if (seen[currNode]) return false;
        seen[currNode] = true;
        foreach (var nextNode in graph[currNode])
        {
            if (Dfs(nextNode, graph, seen, target)) return true;
        }
        return false;
    }
}

// BFS
public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new List<int>();
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        var seen = new bool[n];
        seen[source] = true;
        var q = new Queue<int>();
        q.Enqueue(source);

        while (q.Count > 0)
        {
            var curr = q.Dequeue();
            if (curr == destination) return true;
            foreach (var node in graph[curr])
            {
                if (!seen[node])
                {
                    q.Enqueue(node);
                    seen[node] = true;
                }
            }
        }

        return false;
    }
}
