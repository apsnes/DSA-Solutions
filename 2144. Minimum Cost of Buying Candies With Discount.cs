public class Solution
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);
        var res = 0;
        var candies = 0;
        for (int i = cost.Length - 1; i >= 0; i--)
        {
            candies++;
            if (candies % 3 == 0) continue;
            res += cost[i];
        }
        return res;
    }
}
