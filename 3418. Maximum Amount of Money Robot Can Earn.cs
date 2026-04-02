public class Solution
{
    public int MaximumAmount(int[][] coins)
    {
        var dp = new Dictionary<(int, int, int), int>();
        return PathCost(0, 0, coins, 0, dp);
    }

    private int PathCost(int row, int col, int[][] coins, int neutralCount, Dictionary<(int, int, int), int> dp)
    {
        if (row >= coins.Length || col >= coins[0].Length) return -1000000;
        if (dp.ContainsKey((row, col, neutralCount))) return dp[(row, col, neutralCount)];

        var currSquare = coins[row][col];

        if (row == coins.Length - 1 && col == coins[0].Length - 1)
        {
            if (neutralCount >= 2) return currSquare;
            else return Math.Max(currSquare, 0);
        }

        var rightCost = PathCost(row, col + 1, coins, neutralCount, dp) + currSquare;
        var downCost = PathCost(row + 1, col, coins, neutralCount, dp) + currSquare;
        var maxReturn = Math.Max(downCost, rightCost);

        if (neutralCount < 2 && currSquare < 0)
        {
            var rightCostIgnored = PathCost(row, col + 1, coins, neutralCount + 1, dp);
            var downCostIgnored = PathCost(row + 1, col, coins, neutralCount + 1, dp);
            maxReturn = Math.Max(maxReturn, Math.Max(downCostIgnored, rightCostIgnored));
        }

        dp[(row, col, neutralCount)] = maxReturn;
        return maxReturn;
    }
}
