public class Solution
{
    List<int>[] edges;
    Dictionary<int, int> bobPath;
    int[] amount;

    public int MostProfitablePath(int[][] _edges, int bob, int[] _amount)
    {
        amount = _amount;
        int n = _edges.Length + 1;
        edges = new List<int>[n];
        bobPath = new();

        foreach (var pair in _edges)
        {
            if (edges[pair[0]] == null) edges[pair[0]] = new();
            if (edges[pair[1]] == null) edges[pair[1]] = new();
            edges[pair[0]].Add(pair[1]);
            edges[pair[1]].Add(pair[0]);
        }
        FindBobsPath(bob, 0, -1);
        return FindAlicesPath(0, 0, 0);
    }

    private bool FindBobsPath(int currentNode, int time, int parent)
    {
        bobPath[currentNode] = time;
        if (currentNode == 0) return true;

        foreach (var edge in edges[currentNode])
        {
            if (edge == parent) continue;
            if (FindBobsPath(edge, time + 1, currentNode)) return true;
        }
        bobPath.Remove(currentNode);
        return false;
    }

    private int FindAlicesPath(int time, int currentNode, int parent)
    {
        int res = 0;

        if (!bobPath.ContainsKey(currentNode))
        {
            res += amount[currentNode];
        }
        else
        {
            if (bobPath[currentNode] > time)
            {
                res += amount[currentNode];
            }
            else if (bobPath[currentNode] == time)
            {
                res += amount[currentNode] / 2;
            }
        }
        int max = int.MinValue;
        foreach (var edge in edges[currentNode])
        {
            if (edge == parent) continue;
            max = Math.Max(max, FindAlicesPath(time + 1, edge, currentNode));
        }
        return max == int.MinValue ? res : res + max;
    }
}
