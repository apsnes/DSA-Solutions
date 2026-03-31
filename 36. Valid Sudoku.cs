public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var grids = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            if (rows[i] == null) rows[i] = new HashSet<char>();

            for (int j = 0; j < 9; j++)
            {
                var currNum = board[i][j];
                if (currNum == '.') continue;
                var currGrid = (i / 3 * 3) + (j / 3);

                if (cols[j] == null) cols[j] = new HashSet<char>();
                if (grids[currGrid] == null) grids[currGrid] = new HashSet<char>();

                if (rows[i].Contains(currNum) || cols[j].Contains(currNum) || grids[currGrid].Contains(currNum)) return false;
                rows[i].Add(currNum);
                cols[j].Add(currNum);
                grids[currGrid].Add(currNum);
            }
        }
        return true;
    }
}
