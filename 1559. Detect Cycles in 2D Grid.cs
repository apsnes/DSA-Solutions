public class Solution
{
    public bool ContainsCycle(char[][] grid)
    {
        var seen = new HashSet<(int, int)>();
        List<(int r, int c)> dirs = new() { (0, 1), (0, -1), (1, 0), (-1, 0) };

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (!seen.Contains((i, j)) && Dfs(grid, (i, j), (-1, -1), seen, dirs)) return true;
            }
        }       
        return false;
    }

    private bool Dfs(char[][] grid, (int r, int c) currPos, (int r, int c) prevPos, HashSet<(int, int)> seen, List<(int r, int c)> dirs)
    {
        seen.Add(currPos);
        foreach (var dir in dirs)
        {
            (int r, int c) nextPos = (currPos.r + dir.r, currPos.c + dir.c);
            if (nextPos != prevPos && nextPos.r >= 0 && nextPos.c >= 0 && nextPos.r < grid.Length && nextPos.c < grid[0].Length)
            {
                if (grid[currPos.r][currPos.c] == grid[nextPos.r][nextPos.c] && (seen.Contains(nextPos) || Dfs(grid, nextPos, currPos, seen, dirs))) return true;
            }
        }

        return false;
    }
}
