public class Solution {
    public int LongestSquareStreak(int[] nums)
    {
        int longest = 0;
        SortedSet<int> set = new SortedSet<int>(nums);
        foreach(int num in set)
        {
            int length = 0;
            long currNum = num;
            while (currNum <= int.MaxValue && set.Contains((int)currNum))
            {
                length++;
                currNum = currNum * currNum;
            }
            if (length > 1)
            {
                longest = Math.Max(longest, length);
            }
        }
        return longest > 1 ? longest : -1;
    }
}
