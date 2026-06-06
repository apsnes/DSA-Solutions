public class Solution
{
    public int[] LeftRightDifference(int[] nums) 
    {
        var sum = nums.Sum();
        var res = new int[nums.Length];
        var leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var rightSum = sum - nums[i] - leftSum;
            res[i] = Math.Abs(leftSum - rightSum);
            leftSum += nums[i];
        }
        return res;
    }
}
