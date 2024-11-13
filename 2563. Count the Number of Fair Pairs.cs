public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        return Count(nums, upper) - Count(nums, lower - 1);
    }
    private long Count(int[] nums, int range)
    {
        long ans = 0;
        for (int i = 0, j = nums.Length - 1; i < j; i++)
        {
            while (i < j && nums[i] + nums[j] > range)
            {
                j--;
            }
            ans += j - i;
        }
        return ans;
    }
}
