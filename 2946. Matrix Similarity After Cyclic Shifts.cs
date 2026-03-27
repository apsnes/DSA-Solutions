public class Solution
{
    public bool AreSimilar(int[][] mat, int k)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        k %= n;
        
        if (k == 0) return true;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] != mat[i][(j + k) % n]) return false;
            }
        }
        return true;
    }
}
