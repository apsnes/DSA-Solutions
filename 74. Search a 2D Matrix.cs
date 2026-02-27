// 2D Binary Search Solution

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var top = 0;
        var bottom = matrix.Length - 1;
        var n = matrix[0].Length;

        while (top <= bottom)
        {
            var curr = (top + bottom) / 2;

            if (matrix[curr][0] <= target && matrix[curr][n - 1] >= target)
            {
                return SearchArray(matrix[curr], target);
            }
            if (matrix[curr][0] > target)
            {
                bottom = curr - 1;
            }
            else
            {
                top = curr + 1;
            }
        }
        return false;
    }

    private bool SearchArray(int[] arr, int target)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left <= right)
        {
            var curr = (left + right) / 2;
            if (arr[curr] == target)
            {
                return true;
            }
            if (arr[curr] > target)
            {
                right = curr - 1;
            }
            else
            {
                left = curr + 1;
            }
        }
        return false;
    }
}
