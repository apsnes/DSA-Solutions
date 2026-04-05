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

// Bottom up dp
public class Solution
{
    public int Rob(int[] nums)
    { 
        if (nums.Length == 1) return nums[0];
        var excludeLast = nums[..^1];
        var excludeFirst = nums[1..];
        if (excludeLast.Length == 1) return Math.Max(excludeLast[0], excludeFirst[0]);
        var n = excludeLast.Length;
        var excludeLastMemo = new int[n];
        var excludeFirstMemo = new int[n];
        excludeLastMemo[0] = excludeLast[0];
        excludeLastMemo[1] = Math.Max(excludeLast[0], excludeLast[1]);
        excludeFirstMemo[0] = excludeFirst[0];
        excludeFirstMemo[1] = Math.Max(excludeFirst[0], excludeFirst[1]);

        for (int i = 2; i < n; i++)
        {
            excludeLastMemo[i] = Math.Max(excludeLastMemo[i - 1], excludeLastMemo[i - 2] + excludeLast[i]);
            excludeFirstMemo[i] = Math.Max(excludeFirstMemo[i - 1], excludeFirstMemo[i - 2] + excludeFirst[i]);
        }

        return Math.Max(excludeLastMemo[^1], excludeFirstMemo[^1]);
    }
}

// Optimized bottom up DP 
public class Solution
{
    public int Rob(int[] nums)
    { 
        if (nums.Length == 1) return nums[0];
        var excludeLast = nums[..^1];
        var excludeFirst = nums[1..];
        if (excludeLast.Length == 1) return Math.Max(excludeLast[0], excludeFirst[0]);
        return Math.Max(CalculateArrayValue(excludeLast), CalculateArrayValue(excludeFirst));
    }

    private int CalculateArrayValue(int[] nums)
    {
        int prev2 = nums[0];
        int prev1 = Math.Max(nums[1], nums[0]);
        
        for (int i = 2; i < nums.Length; i++)
        {
            var curr = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = curr;
        }

        return prev1;
    }
}
