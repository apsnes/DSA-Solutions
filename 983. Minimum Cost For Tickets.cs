public class Solution
{
    private int[] _days;
    private int[] _costs;
    private int[] _dp;
    private HashSet<int> isTravelNeeded;
    public int MincostTickets(int[] days, int[] costs)
    {
        _days = days;
        _costs = costs;
        //DP array to store cached values
        _dp = new int[days[^1] + 1];
        //Fill dp array with -1 to indicate values that have not yet been computed
        Array.Fill(_dp, -1);
        //Create a HashSet of days required to travel in order to check if travel is required on a specific day in O(1) time
        isTravelNeeded = new(days);
        return Solve(_days[0]);
    }
    private int Solve(int currDay)
    {
        //If we're past the last day that travel is required, return 0
        if (currDay > _days[^1]) return 0;
        //If we've already computed the result for this days minimum cost, return it
        if (_dp[currDay] != -1) return _dp[currDay];
        //If we don't need to travel on the current day, skip it and move to the next day
        if (!isTravelNeeded.Contains(currDay)) return Solve(currDay + 1);
        //Calculate the minimum cost recursively for each day
        int result = Math.Min(_costs[0] + Solve(currDay + 1), _costs[1] + Solve(currDay + 7));
        result = Math.Min(result, _costs[2] + Solve(currDay + 30));
        //Store the computed result in cache for O(1) retrieval next time
        _dp[currDay] = result;
        return result;
    }
}
