public class Solution {
    public long MaximumSubarraySum(int[] nums, int k)
    {
        long maxSum = 0;
        long currSum = 0;
        Dictionary<int, int> frequencies = new();
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            currSum += nums[right];
            frequencies[nums[right]] = frequencies.GetValueOrDefault(nums[right], 0) + 1;

            if (right - left + 1 > k)
            {
                frequencies[nums[left]]--;
                if (frequencies[nums[left]] == 0)
                {
                    frequencies.Remove(nums[left]);
                }
                currSum -= nums[left];
                left++;
            }
            if (frequencies.Count == k && k == right - left + 1)
            {
                maxSum = Math.Max(maxSum, currSum);
            }
        }
        return maxSum;
    }
}
