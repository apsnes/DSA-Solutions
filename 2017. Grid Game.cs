public class Solution
{
    public long GridGame(int[][] grid)
    {
        int n = grid[0].Length;
        long[] prefix1 = new long[n];
        long[] prefix2 = new long[n];
        long total = 0;
        for (int i = 0; i < n; i++)
        {
            total += grid[0][i];
            prefix1[i] = total;
        }
        total = 0;
        for (int i = 0; i < n; i++)
        {
            total += grid[1][i];
            prefix2[i] = total;
        }
        long minVal = long.MaxValue;
        for (int i = 0; i < n; i++)
        {
            long currentVal = 0;
            if (i > 0) currentVal = Math.Max(prefix1[n-1] - prefix1[i], prefix2[i - 1]);
            else currentVal = prefix1[n-1] - prefix1[i];
            minVal = Math.Min(minVal, currentVal);
        }
        return minVal;
    }
}
