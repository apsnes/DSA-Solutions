public class Solution {
    public int MinSubarray(int[] nums, int p) {
        int n = nums.Length;
        long sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        long k = sum % p;
        if (k == 0)
        {
            return 0;
        }
        int min = n;
        Dictionary<long, int> dict = new();
        dict[0] = -1;
        long currSum = 0;

        for (int i = 0; i < n; i++)
        {
            currSum += nums[i];
            long currMod = currSum % p;
            long currTarget = (currMod - k + p) % p;

            if (dict.ContainsKey(currTarget))
            {
                min = Math.Min(min, i - dict[currTarget]);
            }
            dict[currMod] = i;
        }
        return min == n ? -1 : min;
    }
}
