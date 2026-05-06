public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var res = new int[n][];
        for (int i = 0; i < n; i++)
        {
            res[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                res[i][j] = matrix[j][i];
            }
        }
        return res;
    }
}
