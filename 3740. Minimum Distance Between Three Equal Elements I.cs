public class Solution
{
    public int MinimumDistance(int[] nums)
    {
        if (nums.Length < 3) return -1;
        var dict = new Dictionary<int, List<int>>();
        var res = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i])) dict[nums[i]] = new List<int>();
            dict[nums[i]].Add(i);
            if (dict[nums[i]].Count == 3)
            {
                var currVal = Math.Abs(dict[nums[i]][0] - dict[nums[i]][1]) + Math.Abs(dict[nums[i]][1] - dict[nums[i]][^1]) + Math.Abs(dict[nums[i]][^1] - dict[nums[i]][0]);
                dict[nums[i]].RemoveAt(0);
                res = Math.Min(res, currVal);
            }
        }
        return res == int.MaxValue ? -1 : res;
    }
}
