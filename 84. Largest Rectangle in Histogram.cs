public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        int i = 0;
        Stack<int> stack = new();

        while (i < heights.Length)
        {
            if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
                i++;
            }
            else 
            {
                int height = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
        }

        while (stack.Count != 0)
        {
            int height = heights[stack.Pop()];
            int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
            maxArea = Math.Max(maxArea, height * width);
        }

        return maxArea;
    }
}
