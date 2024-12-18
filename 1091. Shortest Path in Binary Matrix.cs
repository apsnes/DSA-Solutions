//Using BFS algorithm to check all directions on each coordinate on the map

public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        if (grid[0][0] == 1 || grid[^1][^1] == 1) return -1;

        Queue<(int row, int col, int length)> q = new();
        q.Enqueue((0, 0, 1));
        List<(int row, int col)> directions = [ (0, 1), (0, -1), (1, 0), (-1, 0), (1, 1), (-1, -1), (1, -1), (-1, 1) ];

        grid[0][0] = 1;

        while (q.Count > 0)
        {
            var current = q.Dequeue();
            if (current.row == rows - 1 && current.col == cols - 1) return current.length;
            foreach (var tup in directions)
            {
                int currentRow = current.row + tup.row;
                int currentCol = current.col + tup.col;
                int currentLength = current.length;
                if ((currentRow <= rows - 1 && currentRow >= 0) && (currentCol <= cols - 1 && currentCol >= 0) && grid[currentRow][currentCol] == 0)
                {
                    grid[currentRow][currentCol] = 1;
                    q.Enqueue((currentRow, currentCol, currentLength + 1));
                }
            }
        }
        return -1;
    }
}
