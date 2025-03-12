public class Solution
{
    public int MaximumCount(int[] nums)
    {
        int negativeCount = 0;
        int zeroCount = 0;
        foreach (int num in nums)
        {
            if (num < 0) negativeCount++;
            else if (num == 0) zeroCount++;
            else break;
        }
        return Math.Max(negativeCount, nums.Length - (negativeCount + zeroCount));
    }
}
