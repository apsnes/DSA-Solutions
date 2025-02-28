public class Solution
{
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        int s1Len = str1.Length;
        int s2Len = str2.Length;

        string[] prevRow = new string[s2Len + 1];
        for (int col = 0; col <= s2Len; col++)
        {
            prevRow[col] = str2.Substring(0, col);
        }
        for (int row = 1; row <= s1Len; row++)
        {
            string[] currRow = new string[s2Len + 1];
            currRow[0] = str1.Substring(0, row);

            for (int col = 1; col <= s2Len; col++)
            {
                if (str1[row - 1] == str2[col - 1])
                {
                    currRow[col] = prevRow[col - 1] + str1[row - 1];
                }
                else
                {
                    string option1 = prevRow[col];
                    string option2 = currRow[col - 1];

                    currRow[col] = (option1.Length < option2.Length) ? option1 + str1[row - 1] : option2 + str2[col - 1];
                }
            }
            prevRow = currRow;
        }
        return prevRow[s2Len];
    }
}
