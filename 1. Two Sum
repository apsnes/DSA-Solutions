public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        int[] ans = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int newTarget = target - nums[i];
            if (!dict.ContainsKey(newTarget))
            {
                dict[nums[i]] = i;
            }
            else
            {
                ans[0] = dict[newTarget];
                ans[1] = i;
                return ans;
            }
        }
        return ans;
    }
}
