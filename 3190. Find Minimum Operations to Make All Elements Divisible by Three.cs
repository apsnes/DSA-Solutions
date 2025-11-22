// Initial solution
public class Solution {
    public int MinimumOperations(int[] nums)
    {
        return nums.Where(n => n % 3 != 0).Count();
    }
}

// Optimised (no LINQ)
public class Solution {
    public int MinimumOperations(int[] nums)
    {
        var count = 0;
        foreach (var num in nums)
        {
            if (num % 3 != 0)
            {
                count++;
            }
        }
        return count;
    }
}
