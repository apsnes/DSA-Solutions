public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var time = 0;
        var n = points.Length;

        for (int i = 0; i < n - 1; i++)
        {
            var currX = points[i][0];
            var currY = points[i][1];
            var targetX = points[i + 1][0];
            var targetY = points[i + 1][1];
            
            time += Math.Max(Math.Abs(targetX - currX), Math.Abs(targetY - currY));
        }

        return time;
    }
}
