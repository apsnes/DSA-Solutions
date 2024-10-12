public class Solution {
    public int FindMin(int[] nums)
    {   
        int left = 0;
        int right = nums.Length - 1;
        int min = nums[left];
        while (left <= right)
        {
            if (nums[left] < nums[right])
            {
                min = Math.Min(min, nums[left]);
                break;
            }
            int mid = (left + right) / 2;
            min = Math.Min(min, nums[mid]);
            if (nums[mid] >= nums[left])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return min;
    }
}
