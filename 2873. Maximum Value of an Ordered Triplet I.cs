public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        long max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    max = Math.Max(max, (long)(nums[i] - nums[j]) * nums[k]);
                }
            }
        }
        return max > 0 ? max : 0;
    }
}
