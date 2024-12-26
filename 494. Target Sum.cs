//Readable DP solution using dictionary to cache
public class Solution {
    //Keep dictionary to cache already computed results
    Dictionary<(int index, int currentTotal), int> dp = new();

    public int FindTargetSumWays(int[] nums, int target)
    {
        //return result of recursive function
        return backtrack(0, 0, nums, target);
    }
    public int backtrack(int index, int currentTotal, int[] nums, int target)
    {
        //Base case - if we're at the end of the integer array, check if the result of the equation is equal to target
        if (index == nums.Length) return currentTotal == target ? 1 : 0;

        //Base case - result for current index/total has already been computed and cached
        if (dp.ContainsKey((index, currentTotal))) return dp[(index, currentTotal)];

        //Cache the result for current index/total by running the recursive function with both operations
        dp[(index, currentTotal)] = (backtrack(index + 1, currentTotal + nums[index], nums, target)) + 
                                    (backtrack(index + 1, currentTotal - nums[index], nums, target));

        //Return the previously computed result (number of ways to reach target from current index/total)
        return dp[(index, currentTotal)];
    }
}
// -------------------------------------------------------------------------------------
// Initial DP solution
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
