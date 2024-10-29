public class Solution {
    private int n = 0;
    private int m = 0;
    private Dictionary<(int, int), int> dp = [];

    public int MaxMoves(int[][] grid) 
    {
        var ans = 0;
        m = grid.Length;
        n = grid[0].Length;

        for (var i = 0; i < m; i++)
        {
            ans = Math.Max(ans, Solve(i, 0, grid, 0));
        }
        return ans;
    }

    private int Solve(int i, int j, int[][] grid, int nMoves)
    {
        if (dp.TryGetValue((i, j), out var cached))
        {
            return cached;
        }
        var (diagUp, diagDown, right) = (0, 0, 0);
        if (i + 1 < m && j + 1 < n && grid[i][j] < grid[i + 1][j + 1])
        {
            diagUp = Solve(i + 1, j + 1, grid, nMoves + 1);
        }
        if (i < m && j + 1 < n && grid[i][j] < grid[i][j + 1])
        {
            right = Solve(i, j + 1, grid, nMoves + 1);
        }
        if (i - 1 >= 0 && j + 1 < n && grid[i][j] < grid[i - 1][j + 1])
        {
            diagDown = Solve(i - 1, j + 1, grid, nMoves + 1);
        }
        int max = right == 0 && diagUp == 0 && diagDown == 0 ? nMoves : Math.Max(right, Math.Max(diagUp, diagDown));
        dp.Add((i, j), max);
        return max;
    }
}
