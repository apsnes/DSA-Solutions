public class Solution
{
    public long CountBadPairs(int[] nums)
    {
        int n = nums.Length;
        long total = 0;
        Dictionary<int, int> dict = new();

        for (int i = 0; i < n; i++)
        {
            int curr = i - nums[i];
            if (!dict.ContainsKey(curr)) dict[curr] = 0;
            total += i - dict[curr];
            dict[curr]++;
        }
        return total;
    }
}
