public class Solution
{
    public bool IsGood(int[] nums)
    {
        var n = nums.Length;
        var arr = new int[n];
        var count = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] >= n) return false;
            if (arr[nums[i]] == 0)
            {
                arr[nums[i]]++;
                count++;
            }
            else
            {
                if (nums[i] != n - 1) return false;
                arr[nums[i]]++;
                if (arr[nums[i]] > 2) return false;
            }
        }
        return count == n - 1;
    }
}
