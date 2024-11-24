public class Solution {
    public long MaxMatrixSum(int[][] matrix)
    {
        int min = int.MaxValue;
        int negatives = 0;
        long sum = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] < 0) negatives++;
                int absolute = Math.Abs(matrix[i][j]);
                min = Math.Min(min, absolute);
                sum += absolute;
            }
        }
        if (negatives % 2 == 0) return sum;
        return sum - 2 * min;
    }
}
