public class Solution {
    public bool CanPartition(int[] nums)
    {
        int sum = nums.Sum();
        if (sum % 2 != 0) return false;
        Dictionary<(int i, int target), bool> dp = new();
        return CheckArray(nums, 0, sum / 2, dp);
    }
    public bool CheckArray(int[] nums, int index, int target, Dictionary<(int, int), bool> dp)
    {
        if (index >= nums.Length || target < 0) return false;
        if (target == 0) return true;
        if (dp.ContainsKey((index, target))) return dp[(index, target)];
        bool result = CheckArray(nums, index + 1, target, dp) || CheckArray(nums, index + 1, target - nums[index], dp);
        dp[(index, target)] = result;
        return result;
    }
}
