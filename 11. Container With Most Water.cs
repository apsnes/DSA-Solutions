public class Solution
{
    public int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var lowest = Math.Min(heights[left], heights[right]);
            var currArea = (right - left) * lowest;
            maxArea = Math.Max(maxArea, currArea);
            if (heights[right] == lowest)
            {
                while (left < right && heights[right] <= lowest) right--;
            }
            else
            {
                while (left < right && heights[left] <= lowest) left++;
            }           
        }
        return maxArea;
    }
}
