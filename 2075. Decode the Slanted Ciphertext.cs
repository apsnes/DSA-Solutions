// Reconstruction Solution
public class Solution
{
    public string DecodeCiphertext(string encodedText, int rows)
    {
        var cols = encodedText.Length / rows;
        var matrix = new char[rows][];
        var n = encodedText.Length;
        var currIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new char[cols];          
            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = encodedText[currIndex];
                currIndex++;
            }
        }
        
        var sb = new StringBuilder();

        var startingCol = 0;
        var currRow = 0;
        var currCol = 0;

        while (currRow < rows && currCol < cols)
        {
            sb.Append(matrix[currRow][currCol]);
            currRow++;
            currCol++;
            if (currRow == 0 && currCol == cols - 1) break;
            if (currRow >= rows)
            {
                currRow = 0;
                startingCol++;
                currCol = startingCol;
            }
        }
        return sb.ToString().TrimEnd();
    }
}

// Optimised Solution - One pass. Keeps track of current index and increments by column count to select next character.
public class Solution
{
    public string DecodeCiphertext(string encodedText, int rows)
    {
        var cols = encodedText.Length / rows;
        var n = encodedText.Length;
        var currIndex = 0;
        var sb = new StringBuilder();
        var startIndex= 1;

        for (int i = 0; i < n; i++)
        {
            sb.Append(encodedText[currIndex]);
            currIndex += cols + 1;
            if (currIndex > n - 1)
            {
                currIndex = startIndex;
                startIndex++;
            }
        }
        
        return sb.ToString().TrimEnd();
    }
}
