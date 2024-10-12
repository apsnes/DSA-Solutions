public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> list = new List<int>();
        int left = 0;
        int right = matrix[0].Length;
        int top = left;
        int bottom = matrix.Length;     

        while (left < right && top < bottom)
        {
            for (int i = left; i < right; i++)
            {
                list.Add(matrix[top][i]);
            }
            top++;
            for (int i = top; i < bottom; i++)
            {
                list.Add(matrix[i][right - 1]);
            }
            right--;

            if (!(left < right && top < bottom))
            {
                break;
            }

            for (int i = right - 1; i >= left; i--)
            {
                list.Add(matrix[bottom - 1][i]);
            }
            bottom--;
            for(int i = bottom - 1; i >= top; i--)
            {
                list.Add(matrix[i][left]);
            }
            left++;
        }
        return list;
    }
}
