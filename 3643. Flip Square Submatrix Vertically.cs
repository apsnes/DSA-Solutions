public class Solution
{
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
    {
        var m = grid.Length;
        var l = x + k - 1;

        for (int i = x; i < m; i++)
        {
            if (i > l) break;
            for (int j = y; j < y + k; j++)
            {
                var temp = grid[i][j];
                grid[i][j] = grid[l][j];
                grid[l][j] = temp;
            }
            l--;
        }
        return grid;
    }
}
