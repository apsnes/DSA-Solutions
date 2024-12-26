public class Solution {
    public int FindTargetSumWays(int[] nums, int target)
    {
        int totalSum = nums.Sum();
        int[,] dp = new int[nums.Length, 2 * totalSum + 1];
        dp[0,nums[0] + totalSum] = 1;
        dp[0, -nums[0] + totalSum] += 1;
        for (int i = 1; i < nums.Length; i++)
        {
            for (int sum = -totalSum; sum <= totalSum; sum++)
            {
                if (dp[i - 1, sum + totalSum] > 0)
                {
                    dp[i, sum + nums[i] + totalSum] += dp[i - 1, sum + totalSum];
                    dp[i, sum - nums[i] + totalSum] += dp[i - 1, sum + totalSum];
                }
            }
        }
        return Math.Abs(target) > totalSum ? 0 : dp[nums.Length - 1, target + totalSum];
    }
}
