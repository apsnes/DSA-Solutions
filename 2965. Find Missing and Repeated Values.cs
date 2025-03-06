public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        int n = grid.Length;
        HashSet<int> seen = new();
        int[] ans = new int[2];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (seen.Contains(grid[i][j])) ans[0] = grid[i][j];
                seen.Add(grid[i][j]);
            }
        }
        for (int i = 1; i <= n * n; i++)
        {
            if (!seen.Contains(i))
            {
                ans[1] = i;
                break;
            }
        }
        return ans;
    }
}
