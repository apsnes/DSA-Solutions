public class Solution
{
    public bool Check(int[] nums)
    {
        int r = 0;
        int prev = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < prev)
            {
                r = i;
                break;
            }
            prev = nums[i];
        }
        if (r == 0) return true;

        int prevNum = nums[r];
        for (int i = r + 1; i < nums.Length; i++)
        {
            if (nums[i] < prevNum) return false;
            prevNum = nums[i];
        }
        for (int i = 0; i < r; i++)
        {
            if (nums[i] < prevNum) return false;
            prevNum = nums[i];
        }
        return true;
    }
}
