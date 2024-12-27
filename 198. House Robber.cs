//Dynamic programming solution using int[] cache
public class Solution {
    public int Rob(int[] nums)
    {
        int n = nums.Length;
        int[] cache = new int[n];
        //Fill the cache with -1 so that we can see if any value has been saved
        Array.Fill(cache, -1);
        return CalculateMaxMoney(0, cache, n, nums);
    }
    public int CalculateMaxMoney(int index, int[] cache, int n, int[] nums)
    {
        //Base case - we've reached the end of the array
        if (index >= n) return 0;
        //If value has already been computed, return it
        if (cache[index] != -1) return cache[index];
        //Compute max money available for remaining indicies and add it to cache, then return it
        int currentMax = Math.Max(CalculateMaxMoney(index + 1, cache, n, nums), CalculateMaxMoney(index + 2, cache, n, nums) + nums[index]);
        cache[index] = currentMax;
        return currentMax;
    }
}
