public class Solution {
    public int MinCostClimbingStairs(int[] cost)
    {
        int n = cost.Length;
        for (int i = n - 3; i >= 0; i--)
        {
            cost[i] = Math.Min(cost[i] + cost[i + 1], cost[i] + cost[i + 2]); 
        }
        return Math.Min(cost[0], cost[1]);
    }
}
