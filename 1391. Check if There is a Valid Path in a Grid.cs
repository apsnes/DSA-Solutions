public class Solution
{
    public bool HasValidPath(int[][] grid)
    {
        var seen = new HashSet<(int, int)>();
        if (grid.Length == 1 && grid[0].Length == 1) return true;
        var currVal = grid[0][0];
        seen.Add((0, 0));
        if (currVal == 5) return false;
        if (currVal == 4)
        {
            var hasPath = false;
            if (1 < grid[0].Length) hasPath = SearchPath(grid, (0, 1), (0, 0), seen);
            if (!hasPath && 1 < grid.Length) hasPath = SearchPath(grid, (1, 0), (0, 0), seen);
            return hasPath;
        }
        else
        {
            (int r, int c) nextPos = currVal switch
            {
                1 => (0, 1),
                2 => (1, 0),
                3 => (1, 0),
                6 => (0, 1),
                _ => throw new ArgumentException("Invalid start")
            };
            if (nextPos.r < grid.Length && nextPos.c < grid[0].Length) return SearchPath(grid, nextPos, (0, 0), seen);  
        }
        return false;
    }

    private bool IsValidConnection(int prevVal, int nextVal, (int r, int c) prevPos, (int r, int c) nextPos)
    {
        var positionDifference = (nextPos.r - prevPos.r, nextPos.c - prevPos.c);
        var dir = positionDifference switch
        {
            (0, 1) => "r",
            (0, -1) => "l",
            (1, 0) => "d",
            (-1, 0) => "u",
            _ => throw new ArgumentException("Invalid direction change")
        };
        Console.WriteLine(dir);

        if (prevVal == 1)
        {
            if (dir == "r") return nextVal == 3 || nextVal == 5 || nextVal == 1;
            if (dir == "l") return nextVal == 4 || nextVal == 6 || nextVal == 1;
        }
        if (prevVal == 2)
        {
            if (dir == "u") return nextVal == 2 || nextVal == 3 || nextVal == 4;
            if (dir == "d") return nextVal == 2 || nextVal == 5 || nextVal == 6;
        }
        if (prevVal == 3)
        {
            if (dir == "l") return nextVal == 1 || nextVal == 4 || nextVal == 6;
            if (dir == "d") return nextVal == 2 || nextVal == 5 || nextVal == 6;
        }
        if (prevVal == 4)
        {
            if (dir == "r") return nextVal == 1 || nextVal == 3 || nextVal == 5;
            if (dir == "d") return nextVal == 2 || nextVal == 5 || nextVal == 6;
        }
        if (prevVal == 5)
        {
            if (dir == "u") return nextVal == 2 || nextVal == 3 || nextVal == 4;
            if (dir == "l") return nextVal == 1 || nextVal == 4 || nextVal == 6;
        }
        if (prevVal == 6)
        {
            if (dir == "u") return nextVal == 2 || nextVal == 3 || nextVal == 4;
            if (dir == "r") return nextVal == 1 || nextVal == 3 || nextVal == 5;
        }
        return false;
    }

    private bool SearchPath(int[][] grid, (int r, int c) currPos, (int r, int c) prevPos, HashSet<(int, int)> seen)
    {
        if (currPos.r == grid.Length - 1 && currPos.c == grid[0].Length - 1) return true;
        if (seen.Contains(currPos)) return false;
        seen.Add(currPos);

        var currVal = grid[currPos.r][currPos.c];

        (int r, int c) nextPos = currVal switch
        {
            1 => currPos.c > prevPos.c ? (currPos.r, currPos.c + 1) : (currPos.r, currPos.c - 1),
            2 => currPos.r > prevPos.r ? (currPos.r + 1, currPos.c) : (currPos.r - 1, currPos.c),
            3 => currPos.c > prevPos.c ? (currPos.r + 1, currPos.c) : (currPos.r, currPos.c - 1),
            4 => currPos.c < prevPos.c ? (currPos.r + 1, currPos.c) : (currPos.r, currPos.c + 1),
            5 => currPos.c > prevPos.c ? (currPos.r - 1, currPos.c) : (currPos.r, currPos.c - 1),
            6 => currPos.c < prevPos.c ? (currPos.r - 1, currPos.c) : (currPos.r, currPos.c + 1),
            _ => throw new ArgumentException("Invalid value")
        };

        if (nextPos.r >= grid.Length || nextPos.r < 0 || nextPos.c >= grid[0].Length || nextPos.c < 0) return false;

        var nextVal = grid[nextPos.r][nextPos.c];

        if (IsValidConnection(currVal, nextVal, currPos, nextPos))
        {
            Console.WriteLine($"Searching path for {nextPos.r}, {nextPos.c}");
            return SearchPath(grid, nextPos, currPos, seen);
        }
        return false;
    }
}
