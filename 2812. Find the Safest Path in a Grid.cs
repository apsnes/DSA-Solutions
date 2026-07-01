// WIP - TLE
public class Solution
{
    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        var thieves = new HashSet<int[]>();
        var rows = grid.Count;
        var cols = grid[0].Count;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (grid[row][col] == 1) thieves.Add(new int[] { row, col });
            }
        }

        var costGrid = new List<List<int>>();

        for (int row = 0; row < rows; row++)
        {
            costGrid.Add(new List<int>());
            for (int col = 0; col < cols; col++)
            {
                var minDist = int.MaxValue;
                foreach (var thief in thieves)
                {
                    var currDist = CalculateDistance(row, col, thief[0], thief[1]);
                    minDist = Math.Min(minDist, currDist);
                }
                costGrid[row].Add(minDist);
            }
        }

        var res = Dfs(0, 0, int.MaxValue, costGrid, new Dictionary<(int row, int col, int cost), int>(), new HashSet<(int row, int col)>());
        return res;
    }

    private int Dfs(int row, int col, int currCost, List<List<int>> grid, Dictionary<(int row, int col, int cost), int> costDict, HashSet<(int row, int col)> visited)
    {
        visited.Add((row, col));
        currCost = currCost == -1 ? grid[row][col] : Math.Min(currCost, grid[row][col]);
        if (costDict.ContainsKey((row, col, currCost))) return costDict[(row, col, currCost)];
        if (currCost == 0)
        {
            costDict[(row, col, currCost)] = 0;
            return 0;
        }
        if (row == grid.Count - 1 && col == grid[0].Count - 1) return currCost;

        var rightCost = int.MinValue;
        var downCost = int.MinValue;
        var leftCost = int.MinValue;
        var upCost = int.MinValue;
        if (col + 1 < grid[0].Count && !visited.Contains((row, col + 1))) 
        {
            rightCost = Dfs(row, col + 1, currCost, grid, costDict, visited);
            visited.Remove((row, col + 1));
        }

        if (row + 1 < grid.Count && !visited.Contains((row + 1, col)))
        {
            downCost = Dfs(row + 1, col, currCost, grid, costDict, visited);
            visited.Remove((row + 1, col));
        } 
        if (col - 1 >= 0 && !visited.Contains((row, col - 1)))
        {
            leftCost = Dfs(row, col - 1, currCost, grid, costDict, visited);
            visited.Remove((row, col - 1));
        } 
        if (row - 1 >= 0 && !visited.Contains((row - 1, col)))
        {
            upCost = Dfs(row - 1, col, currCost, grid, costDict, visited);
            visited.Remove((row - 1, col));
        } 
        var horCost = Math.Max(rightCost, leftCost);
        var verCost = Math.Max(upCost, downCost);
        var maxCost = Math.Max(horCost, verCost);
        costDict[(row, col, currCost)] = maxCost;
        Console.WriteLine($"{row}, {col}: {maxCost}");
        return maxCost;
    }

    private int CalculateDistance(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }
}
