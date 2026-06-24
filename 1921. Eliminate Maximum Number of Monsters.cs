public class Solution
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        var n = dist.Length;
        if (n == 0) return 0;
        var time = new double[n];
        for (int i = 0; i < n; i++)
        {
            time[i] = (double) dist[i] / speed[i];
        }
        Array.Sort(time);

        var res = 1;
        for (int i = 1; i < time.Length; i++)
        {
            if (time[i] <= i) break;
            res++;
        }
        return res;
    }
}
