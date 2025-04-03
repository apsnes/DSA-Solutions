public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        long res = 0;
        int n = nums.Length;
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        for (int i  = 1; i < n; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], nums[i - 1]);
            rightMax[n - 1 - i] = Math.Max(rightMax[n - i], nums[n - i]);
        }

        for (int i = 1; i < n - 1; i++)
        {
            res = Math.Max(res, (long)(leftMax[i] - nums[i]) * rightMax[i]);
        }
        return res;
    }
}
