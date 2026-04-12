public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = new List<int[]>();
        var added = false;

        for (int i = 0; i < intervals.Length; i++)
        {
            if (newInterval[1] < intervals[i][0])
            {
                res.Add(newInterval);
                res.AddRange(intervals.Skip(i).ToArray());
                return res.ToArray();
            }
            else if (newInterval[0] > intervals[i][1])
            {
                res.Add(intervals[i]);
            }
            else
            {
                newInterval = new int[] { Math.Min(intervals[i][0], newInterval[0]), Math.Max(intervals[i][1], newInterval[1]) };
            }
        }
        res.Add(newInterval);

        return res.ToArray();
    }
}
