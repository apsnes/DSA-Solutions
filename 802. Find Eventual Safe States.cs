public class Solution
{
    Dictionary<int, bool> isSafe = new();
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        int n = graph.Length;
        List<int> result = new();
        for (int i = 0; i < n; i++)
        {
            if (dfs(i, graph))
            {
                result.Add(i);
            }
        }
        return result;
    }

    private bool dfs(int i, int[][] graph)
    {
        if (isSafe.ContainsKey(i)) return isSafe[i];
        isSafe[i] = false;

        foreach (int neighbour in graph[i])
        {
            if (!dfs(neighbour, graph))
            {
                return false;
            }
        }
        isSafe[i] = true;
        return true;
    }
}
