public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        Dictionary<string, int> counts = new();
        foreach (int[] row in matrix)
        {
            int[] key = new int [row.Length];
            for (int i = 0; i < row.Length; i++)
            {
                key[i] = row[0] == 1 ? 1 - row[i] : row[i];
            }
            string rowKey = string.Join(",", key);
            counts[rowKey] = counts.GetValueOrDefault(rowKey, 0) + 1;
        }
        return counts.Values.Max();
    }
}
