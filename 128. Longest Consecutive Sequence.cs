public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var numSet = new HashSet<int>(nums);
        var maxLength = 0;

        foreach (var num in nums)
        {
            if (!numSet.Contains(num - 1))
            {
                var currLength = 1;
                while (numSet.Contains(num + currLength))
                {
                     currLength++;
                }
                maxLength = Math.Max(currLength, maxLength);
            }
        }

        return maxLength;
    }
}
