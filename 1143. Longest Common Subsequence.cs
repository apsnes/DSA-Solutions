public class Solution
{
    int[,] dp;
    int i;
    int j;
    public int LongestCommonSubsequence(string text1, string text2)
    {
        i = text1.Length;
        j = text2.Length;
        //Create a DP array to store previously computed cached values
        dp = new int[i, j];
        //Set all values to -1. This allows us to see when a value has
        //been changed
        for (int x = 0; x < i; x++)
        {
            for (int y = 0; y < j; y++)
            {
                dp[x, y] = -1;
            }
        }
        return CheckStrings(text1, text2, 0, 0);
    }
    public int CheckStrings(string text1, string text2, int x, int y)
    {
        //If we're out of bounds, return 0
        if (x == i || y == j) return 0;
        //If the value from this index has already been computed, return it
        if (dp[x, y] != - 1) return dp[x, y];
        //Check if current indexes of the strings are equal. If they are,
        //go 'diagonally' plus 1 in the 2D array and add 1. This essentially
        //skips over this index but adds 1 to our final result. If the
        //characters are not equal, compute the max value of computing
        //x + 1 and y + 1. Do not add 1 this time, as matched characters
        //were not found
        int result = text1[x] == text2[y] ?
        CheckStrings(text1, text2, x + 1, y + 1) + 1 :
        Math.Max(CheckStrings(text1, text2, x + 1, y), 
        CheckStrings(text1, text2, x, y + 1));
        //Store computed result in the dp cache and return it
        dp[x, y] = result;
        return result;
    }
}
