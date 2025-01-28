public class Solution
{
    public int FindMaxFish(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        int maxValue = 0;
        HashSet<(int, int)> seen = new();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] > 0)
                {
                    maxValue = Math.Max(maxValue, dfs(i, j, grid, seen));
                }
            }
        }
        return maxValue;
    }

    private int dfs(int i, int j, int[][] grid, HashSet<(int, int)> seen)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0 || seen.Contains((i, j))) return 0;
        seen.Add((i, j));
        int currTotal = 0;
        currTotal += dfs(i - 1, j, grid, seen);
        currTotal += dfs(i + 1, j, grid, seen);
        currTotal += dfs(i, j - 1, grid, seen);
        currTotal += dfs(i, j + 1, grid, seen);
        currTotal += grid[i][j];
        return currTotal;
    }
}
