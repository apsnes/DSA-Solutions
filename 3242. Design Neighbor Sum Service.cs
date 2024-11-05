public class NeighborSum {

    public int[][] Grid { get; set; }
    public int N { get; set; }
    public int M { get; set; }

    public NeighborSum(int[][] grid)
    {
        Grid = grid;
        M = grid[0].Length;
        N = grid.Length;
    }
    
    public int AdjacentSum(int value)
    {
        int ans = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (Grid[i][j] == value)
                {
                    if (i > 0) ans += Grid[i - 1][j];
                    if (i < M - 1) ans += Grid[i + 1][j];
                    if (j > 0) ans += Grid[i][j - 1];
                    if (j < N - 1) ans += Grid[i][j + 1];
                }
            }
        }
        return ans;
    }
    
    public int DiagonalSum(int value)
    {
        int ans = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (Grid[i][j] == value)
                {
                    if (i > 0 && j > 0) ans += Grid[i - 1][j - 1];
                    if (i < M - 1 && j < N - 1) ans += Grid[i + 1][j + 1];
                    if (j < M - 1 && i > 0) ans += Grid[i - 1][j + 1];
                    if (j > 0 && i < N - 1) ans += Grid[i + 1][j - 1];
                }
            }
        }
        return ans;      
    }
}

/**
 * Your NeighborSum object will be instantiated and called as such:
 * NeighborSum obj = new NeighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */
