public class Solution {
    public long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        List<int> nRobot = new List<int>(robot);
        nRobot.Sort();
        Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));
        int n = robot.Count;
        int m = factory.Length;

        long[,] dp = new long[m + 1, n + 1];
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <=n; j++)
            {
                dp[i,j] = long.MaxValue / 2;
            }
        }
        dp[0, 0] = 0;

        for (int i = 1; i <= m; i++)
        {
            int position = factory[i - 1][0];
            int limit = factory[i - 1][1];
            for (int j = 0; j <= n; j++)
            {
                dp[i, j] = dp[i - 1, j];
                long cost = 0;
                for (int k = 1; k <= limit && j - k >= 0; k++)
                {
                    cost += Math.Abs(nRobot[j - k] - position);
                    dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - k] + cost);
                }
            }
        }
        return dp[m, n];
    }
}
