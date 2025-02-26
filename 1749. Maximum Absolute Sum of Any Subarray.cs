public class Solution
{
    public int MaxAbsoluteSum(int[] nums)
    {
        int minSum = int.MaxValue;
        int maxSum = int.MinValue;
        int pre = 0;
        int maxAbs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            pre += nums[i];
            minSum = Math.Min(minSum, pre);
            maxSum = Math.Max(maxSum, pre);
            if (pre >= 0)
            {
                maxAbs = Math.Max(maxAbs, Math.Max(pre, pre - minSum));
            }
            else 
            {
                maxAbs = Math.Max(maxAbs, Math.Max(Math.Abs(pre), Math.Abs(pre - maxSum)));
            }
        }
        return maxAbs;
    }
}
