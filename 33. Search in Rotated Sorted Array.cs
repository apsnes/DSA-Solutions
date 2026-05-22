public class Solution
{
    public int Search(int[] nums, int target)
    {
        var n = nums.Length;
        int left = 0, right = n - 1;
        var rotated = nums[0] > nums[n - 1];
        var min = nums[0];
        var deflectionIndex = 0;

        while (rotated && left <= right)
        {
            if (nums[left] < nums[right])
            {
                if (nums[left] < min) deflectionIndex = left;
                break;
            }

            var mid = (left + right) / 2;           
            if (nums[mid] < min)
            {
                deflectionIndex = mid;
                min = nums[mid];
            }
            if (nums[mid] >= nums[left])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        var firstRes = BinarySearch(nums[..deflectionIndex], target);
        if (firstRes != -1) return firstRes;
        var secondRes = BinarySearch(nums[deflectionIndex..], target);
        if (secondRes != -1) return secondRes + deflectionIndex;
        return -1;
    }

    private int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target) right = mid - 1;
            if (nums[mid] < target) left = mid + 1;
        }
        return -1;
    }
}
