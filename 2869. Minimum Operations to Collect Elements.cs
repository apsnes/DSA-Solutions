public class Solution
{
    public int MinOperations(IList<int> nums, int k)
    {
        var res = 0;
        var set = new HashSet<int>();
        for (int i = nums.Count - 1; i >= 0; i--)
        {
            res++;
            if (nums[i] <= k)
            {
                set.Add(nums[i]);
                if (set.Count == k) return res;
            }
        }
        return res;
    }
}
