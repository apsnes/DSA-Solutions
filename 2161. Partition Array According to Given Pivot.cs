public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        int[] ans = new int[nums.Length];
        int lessI = 0;
        int greaterI = nums.Length - 1;
        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        {
            if (nums[i] < pivot)
            {
                ans[lessI] = nums[i];
                lessI++;
            }
            if (nums[j] > pivot)
            {
                ans[greaterI] = nums[j];
                greaterI--;
            }
        }
        while (lessI <= greaterI)
        {
            ans[lessI] = pivot;
            lessI++;
        }
        return ans;
    }
}
