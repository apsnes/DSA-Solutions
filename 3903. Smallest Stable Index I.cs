public class Solution
{
    public int FirstStableIndex(int[] nums, int k)
    {
        int[] min = new int[nums.Length];
        min[^1] = nums[^1];
        var bestScore = int.MaxValue;
        var currMax = int.MinValue;
        
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            min[i] = Math.Min(min[i + 1], nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            currMax = Math.Max(currMax, nums[i]);
            var currScore = currMax - min[i];
            if (currScore <= k) return i;
        }

        return -1;
    }
}
