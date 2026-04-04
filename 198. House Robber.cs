// Top down dynamic programming
public class Solution
{
    private int[] _nums;
    private Dictionary<int, int> _dict = new();

    public int Rob(int[] nums)
    {
        _nums = nums;
        return Math.Max(CalculateValue(0), CalculateValue(1));
    }

    private int CalculateValue(int currHouse)
    {
        if (currHouse >= _nums.Length) return 0;
        if (_dict.ContainsKey(currHouse)) return _dict[currHouse];
        var res = _nums[currHouse] + Math.Max(CalculateValue(currHouse + 2), CalculateValue(currHouse + 3));
        _dict[currHouse] = res;
        return res;
    }
}

// Bottom up dynamic programming
public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        var dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(dp[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
        }

        return dp[^1];
    }
}
