public class Solution {
    public int CountSquares(int[][] matrix)
    {
        int m = matrix[0].Length;
        int n = matrix.Length;
        int ans = 0;
        int[][] newMatrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            newMatrix[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                if (matrix[i][j] == 1)
                {
                    if (i == 0 || j == 0)
                    {
                        newMatrix[i][j] = 1;
                    }
                    else
                    {
                        newMatrix[i][j] = Math.Min(newMatrix[i-1][j-1], Math.Min(newMatrix[i][j-1], newMatrix[i-1][j])) + 1;
                    }
                    ans += newMatrix[i][j];
                }
            }
        }
        return ans;
    }
}
