public class Solution
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        int n = mat.Length;
        int m = mat[0].Length;
        int[] rows = new int[n];
        int[] cols = new int[m];
        Dictionary<int, (int, int)> dict = new();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                dict[mat[i][j]] = (i, j);
            }
        }
        for (int ansIndex = 0; ansIndex < arr.Length; ansIndex++)
        {
            var coords = dict[arr[ansIndex]];
            rows[coords.Item1]++;
            cols[coords.Item2]++;
            if (rows[coords.Item1] == m || cols[coords.Item2] == n) return ansIndex;
        }
        return -1;
    }
}
