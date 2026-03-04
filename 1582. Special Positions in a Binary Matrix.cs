public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var rowCounts = new int[m];
        var colCounts = new int[n];
        HashSet<(int, int)> specialPositions = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1)
                {
                    rowCounts[i]++;
                    colCounts[j]++;
                    specialPositions.Add((i, j));
                }
            }
        }
        return specialPositions.Count(x => rowCounts[x.Item1] == 1 && colCounts[x.Item2] == 1);
    }
}
