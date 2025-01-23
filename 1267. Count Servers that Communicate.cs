public class Solution
{
    public int CountServers(int[][] grid) 
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[] rowCounts = new int[rows];
        int[] colCounts = new int[cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    rowCounts[i]++;
                    colCounts[j]++;
                }
            }
        }
        int total = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1 && Math.Max(rowCounts[i], colCounts[j]) > 1)
                {
                    total += 1;
                }
            }
        }
        return total;
    }
}
