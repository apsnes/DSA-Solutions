// Question is basicslly 'find the minimum edge cost for all nodes connected to node "1"'. Solution - map all nodes that eventually
// connect to 1 with DFS. Loop through nodes and and check edge cost for all in the same connected graph as "1".

public class Solution
{
    public int MinScore(int n, int[][] roads)
    {
        var minDist = int.MaxValue;
        var graph = new Dictionary<int, List<int>>();

        foreach (var edge in roads)
        {
            if (!graph.ContainsKey(edge[0])) graph[edge[0]] = new();
            graph[edge[0]].Add(edge[1]);
            if (!graph.ContainsKey(edge[1])) graph[edge[1]] = new();
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n + 1];
        FillPathsByDfs(1, graph, visited);

        foreach (var edge in roads)
        {
            if (visited[edge[0]] || visited[edge[1]])
            {
                minDist = Math.Min(minDist, edge[2]);
            }
        }
        return minDist;
    }

    private void FillPathsByDfs(int currNode, Dictionary<int, List<int>> graph, bool[] visited)
    {
        if (visited[currNode]) return;
        visited[currNode] = true;
        foreach (var neighbour in graph[currNode]) FillPathsByDfs(neighbour, graph, visited);
    }
}
