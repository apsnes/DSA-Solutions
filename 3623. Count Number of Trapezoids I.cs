public class Solution
{
    public int CountTrapezoids(int[][] points)
    {
        var pointsDict = points.GroupBy(p => p[1]).ToDictionary(g => g.Key, g => g.ToList());
        long result = 0;
        long sum = 0;
        var mod = 1000000007;

        foreach (var kvp in pointsDict)
        {
            var pointCount = kvp.Value.Count();
            var edge = (long)pointCount * (pointCount - 1) / 2;
            result = (result + edge * sum) % mod;
            sum= (sum + edge) % mod;
        }

        return (int)result;
    }
}
