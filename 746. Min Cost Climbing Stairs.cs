// Fast one pass sum
public class Solution
{
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

// Dynamic Programming
public class Solution
{
    private int[] _cost;
    private Dictionary<int, int> _dict = new();
    private int _topFloor;

    public int MinCostClimbingStairs(int[] cost)
    {
        _cost = cost;
        _topFloor = cost.Length;
        return Math.Min(CalculateMinCost(0), CalculateMinCost(1));
    }

    private int CalculateMinCost(int currStep)
    {
        if (currStep >= _topFloor) return 0;
        if (_dict.ContainsKey(currStep)) return _dict[currStep];
        var res = _cost[currStep] + Math.Min(CalculateMinCost(currStep + 1), CalculateMinCost(currStep + 2));
        _dict[currStep] = res;
        return res;
    }
}
