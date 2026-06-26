public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0) return 0;

        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        var res = 1;
        var currEnd = points[0][1];

        foreach (var point in points)
        {
            if (point[0] <= currEnd) currEnd = Math.Min(currEnd, point[1]);
            else
            {
                res++;
                currEnd = point[1];
            }
        }
        
        return res;
    }
}
