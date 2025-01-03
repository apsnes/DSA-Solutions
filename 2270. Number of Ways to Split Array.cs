public class Solution
{
    public int WaysToSplitArray(int[] nums)
    {
        //Initialise a variable to track the number of valid splits found
        int ans = 0;
        //Create a prefix sum array
        long[] pre = new long[nums.Length];
        //Set index 0 of the prefix sum array to nums[0]
        pre[0] = nums[0];
        //Iterate from 1 to n - 1, calculating the prefix sum at that index
        for (int i = 1; i < nums.Length; i++)
        {
            pre[i] = pre[i - 1] + nums[i];
        }
        //Iterate from pre[0] to pre[n - 2] to check for valid splits
        for (int i = 0; i < nums.Length - 1; i++)
        {
            //If the current prefix value is greater than or equal to
            //the value in the remaining part of the array (calculted 
            //by subtracting the current value from the final value 
            //found in the last index), increment ans by 1
            if (pre[i] >= pre[^1] - pre[i]) ans++;
        }
        return ans;
    }
}
