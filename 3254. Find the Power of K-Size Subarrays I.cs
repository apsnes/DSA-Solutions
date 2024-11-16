public class Solution {
    public int[] ResultsArray(int[] nums, int k)
    {
        if (k == 1) return nums;

        int n = nums.Length;
        int[] results = new int [n - k + 1];
        int index = 0;
        int left = 0;
        int right = 1;

        while (right < n)
        {
            bool isConsecutive = nums[right - 1] + 1 == nums[right];
            if (!isConsecutive)
            {
                while (left < right && left + k - 1 < n)
                {
                    results[index] = -1;
                    left++;
                    index++;
                }
                left = right;
            }
            else if (right - left == k - 1)
            {
                results[index] = nums[right];
                left++;
                index++;
            }
            right++;
        }
        return results;
    }
}
