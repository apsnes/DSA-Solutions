//Space optimised DP solution:


//DP Cache solution:
public class Solution
{
    Dictionary<(int, int), int> dp = new(); 
    public int UniquePaths(int m, int n)
    {
        return CheckPaths(0, 0, m, n);
    }
    public int CheckPaths(int x, int y, int m, int n)
    {
        if (x == m - 1 && y == n - 1) return 1;
        if (x >= m || y >= n) return 0;
        if (dp.ContainsKey((x, y))) return dp[(x, y)];
        int result = CheckPaths(x + 1, y, m, n) + CheckPaths(x, y + 1, m, n);
        dp[(x, y)] = result;
        return result;
    }
}
