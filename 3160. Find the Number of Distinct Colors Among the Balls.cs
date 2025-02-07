public class Solution
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        int n = queries.Length;
        int[] res = new int[n];
        Dictionary<int, int> colors = new();
        Dictionary<int, int> balls = new();
        for (int i = 0; i < n; i++)
        {
            int ball = queries[i][0];
            int color = queries[i][1];
            if (balls.ContainsKey(ball))
            {
                int prev = balls[ball];
                colors[prev]--;
                if (colors[prev] == 0) colors.Remove(prev);
            }
            balls[ball] = color;
            if (!colors.ContainsKey(color)) colors[color] = 0;
            colors[color]++;
            res[i] = colors.Count();
        }
        return res;
    }
}
