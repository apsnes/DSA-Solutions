//Dynamic programming cache solution
public class Solution
{
    Dictionary<int, int> cache = new();
    public int ClimbStairs(int n)
    {
        return CalculateWays(n);
    }
    public int CalculateWays(int remainingDistance)
    {
        if (remainingDistance <= 1) return 1;
        if (cache.ContainsKey(remainingDistance)) return cache[remainingDistance];
        int numberOfWays = CalculateWays(remainingDistance - 2) + CalculateWays(remainingDistance - 1);
        cache[remainingDistance] = numberOfWays;
        return numberOfWays;
    }
}
