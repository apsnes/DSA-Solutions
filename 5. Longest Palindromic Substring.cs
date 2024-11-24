public class Solution {
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int[] longestPalindromeIndicies = { 0, 0 };

        for (int i = 0; i < s.Length; i++)
        {
            int[] currentIndicies = ExpandIndicies(s, i, i);
            if (currentIndicies[1] - currentIndicies[0] > longestPalindromeIndicies[1] - longestPalindromeIndicies[0])
            {
                longestPalindromeIndicies = currentIndicies;
            }
            if (i + 1 < s.Length && s[i] == s[i + 1])
            {
                int[] evenIndicies = ExpandIndicies(s, i, i + 1);
            
                if (evenIndicies[1] - evenIndicies[0] > longestPalindromeIndicies[1] - longestPalindromeIndicies[0])
                {
                    longestPalindromeIndicies = evenIndicies;
                }
            }
        }
        return s.Substring(longestPalindromeIndicies[0], longestPalindromeIndicies[1] - longestPalindromeIndicies[0] + 1);
    }
    private int[] ExpandIndicies(string s, int i, int j)
    {
        while (i >= 0 && j < s.Length && s[i] == s[j])
        {
            i--;
            j++;
        }
        return new int[] { i + 1, j - 1 };
    }
}
