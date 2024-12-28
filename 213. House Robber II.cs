public class Solution
{
    public int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return nums[0];
        int[][] cache = new int[n][];
        //Fill cache with -1 so that we can see when a value has been cached
        for (int i = 0; i < n; i++)
        {
            cache[i] = new int[] { -1, -1 };
        }
        //Intuition tells us the problem is simply whether houses i - n-2 generates more money than houses i+1 - n-1 does. We can run the method on both and return the max value
        return Math.Max(CalculateMaxMoney(0, n, cache, nums, 1), CalculateMaxMoney(1, n, cache, nums, 0));
    }
    public int CalculateMaxMoney(int index, int n, int[][] cache, int[] nums, int flag)
    {
        //Base case - end of the array
        if (index >= n || (flag == 1 && index == n - 1)) return 0;
        //Case - result for current position has already been computed, return it.
        if (cache[index][flag] != -1) return cache[index][flag];
        //Add current to cache
        cache[index][flag] = Math.Max(CalculateMaxMoney(index + 1, n, cache, nums, flag), nums[index] + CalculateMaxMoney(index + 2, n, cache, nums, flag | (index == 0 ? 1 : 0)));
        return cache[index][flag];
    }
}
