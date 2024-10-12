public class Solution {
    public int MaxWidthRamp(int[] nums)
    {
        Stack<int> stack = new();
        int maxWidth = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (stack.Count == 0 || nums[i] < nums[stack.Peek()])
            {
                stack.Push(i);
            }
        }

        for (int j = nums.Length - 1; j >= 0; j--)
        {
            while (stack.Count > 0 && nums[stack.Peek()] <= nums[j])
            {
                maxWidth = Math.Max(maxWidth, (j - stack.Pop()));
            }
        }
        return maxWidth;
    }
}
