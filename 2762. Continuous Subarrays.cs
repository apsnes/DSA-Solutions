public class Solution
{
    public long ContinuousSubarrays(int[] nums)
    {
        SortedDictionary<int, int> map = new();
        int left = 0;
        int right = 0;
        int n = nums.Length;
        long count = 0;
        while (right < n)
        {
            if (!map.ContainsKey(nums[right])) map[nums[right]] = 0;
            map[nums[right]]++;
            while (map.Last().Key - map.First().Key > 2)
                {
                    map[nums[left]]--;
                    if (map[nums[left]] == 0) map.Remove(nums[left]);
                    left++;
                }
            count += right - left + 1;
            right++;
        }
        return count;
    }
}
