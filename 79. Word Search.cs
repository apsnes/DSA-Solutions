public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && Backtrack(board, word, 0, i, j)) return true;
            }
        }
        return false;
    }

    private bool Backtrack(char[][] board, string word, int i, int row, int col)
    {
        if (row >= board.Length || row < 0 || col >= board[0].Length || col < 0 || board[row][col] != word[i])
        {
            return false;
        }
        if (i == word.Length - 1) return true;

        var exists = false;

        if (board[row][col] == word[i])
        {
            var temp = board[row][col];
            board[row][col] = ' ';
            if (Backtrack(board, word, i + 1, row + 1, col) ||
            Backtrack(board, word, i + 1, row - 1, col) ||
            Backtrack(board, word, i + 1, row, col + 1) ||
            Backtrack(board, word, i + 1, row, col - 1)) return true;
            board[row][col] = temp;
        }
        return false;
    }
}
