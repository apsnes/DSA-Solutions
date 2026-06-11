public class Solution
{
    private int _maxDepth = 0;

    public int AssignEdgeWeights(int[][] edges)
    {
        var mod = (int)Math.Pow(10, 9) + 7;
        var neighbourDict = new Dictionary<int, List<int>>();
        foreach (var edge in edges)
        {
            if (!neighbourDict.ContainsKey(edge[0])) neighbourDict[edge[0]] = new();
            neighbourDict[edge[0]].Add(edge[1]);
            if (!neighbourDict.ContainsKey(edge[1])) neighbourDict[edge[1]] = new();
            neighbourDict[edge[1]].Add(edge[0]);
        }
        var visited = new HashSet<int>();
        Dfs(neighbourDict, 1, visited, 0);
        return (int)BigInteger.ModPow(2, _maxDepth - 1, mod);
    }

    private void Dfs(Dictionary<int, List<int>> neighbourDict, int node, HashSet<int> visited, int currentDepth)
    {
        visited.Add(node);
        _maxDepth = Math.Max(_maxDepth, currentDepth);
        foreach (int neighbour in neighbourDict[node])
        {
            if (!visited.Contains(neighbour))
            {
                Dfs(neighbourDict, neighbour, visited, currentDepth + 1);
            }
        }
    }
}
