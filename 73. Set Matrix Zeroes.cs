public class Solution {
    public void SetZeroes(int[][] matrix)
    {
        int n = matrix[0].Length;
        int m = matrix.Length;

        HashSet<(int, int)> set = new();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    set.Add((i, j));
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (set.Contains((i, j)))
                {
                    for (int column = 0; column < m; column++)
                    {
                        matrix[column][j] = 0;
                    }
                    for (int row = 0; row < n; row++)
                    {
                        matrix[i][row] = 0;
                    }
                }
            }
        }
    }
}
