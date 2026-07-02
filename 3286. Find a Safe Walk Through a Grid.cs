// DFS
public class Solution
{
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        return Dfs(0, 0, grid, health, new HashSet<(int row, int col, int hp)>());
    }

    private bool Dfs(int row, int col, IList<IList<int>> grid, int hp, HashSet<(int row, int col, int hp)> visited)
    {
        hp -= grid[row][col];
        if (hp <= 0) return false;
        if (visited.Contains((row, col, hp))) return false;
        visited.Add((row, col, hp));
        if (row == grid.Count - 1 && col == grid[0].Count - 1) return true;
        bool downRes = false, rightRes = false, leftRes = false, upRes = false;
        if (row + 1 < grid.Count) downRes = Dfs(row + 1, col, grid, hp, visited);
        if (row - 1 >= 0) upRes = Dfs(row - 1, col, grid, hp, visited);
        if (col + 1 < grid[0].Count) rightRes = Dfs(row, col + 1, grid, hp, visited);
        if (col - 1 >= 0) leftRes = Dfs(row, col - 1, grid, hp, visited);
        return (downRes || leftRes || upRes || rightRes);
    }
}

// 01 BFS
public class Solution
{
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        var dirs = new int[][]
        {
            new int[] { 1, 0 }, new int[] { 0, 1 },
            new int[] { -1, 0 }, new int[] { 0, -1 }
        };

        int m = grid.Count, n = grid[0].Count;
        var dis = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dis[i] = new int[n];
            Array.Fill(dis[i], int.MaxValue);
        }

        var pq = new PriorityQueue<int[], int>();
        pq.Enqueue(new int[] { 0, 0 }, grid[0][0]);
        dis[0][0] = grid[0][0];

        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            int currX = curr[0], currY = curr[1];
            if (currX == m - 1 && currY == n - 1) return true;

            foreach (var dir in dirs)
            {
                int newX = currX + dir[0], newY = currY + dir[1];
                if (newX < 0 || newX >= m || newY < 0 || newY >= n) continue;
                var cost = dis[currX][currY] + grid[newX][newY];
                if (cost >= health) continue;
                if (cost < dis[newX][newY])
                {
                    dis[newX][newY] = cost;
                    pq.Enqueue(new int[] { newX, newY }, grid[newX][newY]);
                }
            }
        }

        return false;
    }
}
