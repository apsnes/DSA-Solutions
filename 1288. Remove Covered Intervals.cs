public class Solution
{
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        var res = 0;
        for (int i = 0; i < intervals.Length; i++)
            if (!IsCovered(intervals[i], intervals)) res++;
        return res;
    }

    private bool IsCovered(int[] curr, int[][] intervals)
    {
        foreach (var interval in intervals)
        {
            if (curr == interval) continue;
            if (interval[0] <= curr[0] && interval[1] >= curr[1])
                return true;
        }
        return false;
    }
}
