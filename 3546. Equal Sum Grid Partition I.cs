public class Solution
{
    public bool CanPartitionGrid(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        long remainingVertical = 0;

        for (int i = 0; i < m; i++)
        {
            foreach (var num in grid[i])
            {
                remainingVertical += num;
            }
        }

        long remainingHorizontal = remainingVertical;
        long currVertical = 0;
        long currHorizontal = 0;

        for (int i = 0; i < m; i++)
        {
            long currSum = 0;

            foreach (var num in grid[i])
            {
                currSum += num;
            }

            currHorizontal += currSum;
            remainingHorizontal -= currSum;
            if (remainingHorizontal == currHorizontal)
            {
                return true;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                currVertical += grid[j][i];
                remainingVertical -= grid[j][i];
            }
            if (currVertical == remainingVertical)
            {
                return true;
            }
        }
        return false;
    }
}
