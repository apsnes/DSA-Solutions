public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int n = nums.Length;
        //DP array to cache computed values
        int[] LIS = new int[n];
        //Set last index's max length to 1 (there are no possible numbers after it to create a subarray from)
        LIS[n - 1] = 1;
        //Iterate backwards from n-2
        for (int i = n - 2; i >= 0; i--)
        {
            //Set the base value of the current index to 1, this is the worst case scenario (shortest possible length)
            LIS[i] = 1;
            //Iterate from the current index + 1 to the end of the array. Whevever we come across a number that is
            //strictly greater than the number at the current index, we check our dp array to see what the longest
            //posssible subsequence we can make from it was. We update the current index in our dp array if we have found
            //a new max possible length
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] < nums[j])
                {
                    LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                }
            }
        }
        //Return the longest length we saw throughout the algorithm
        return LIS.Max();
    }
}
