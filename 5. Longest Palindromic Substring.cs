//New readable solution:

public class Solution
{
    //Initialise variables to keep track of the index that the longest pallindrome begins at, and its total length
    int resultIndex = 0;
    int resultLength = 0;   
    public string LongestPalindrome(string s)
    {
        //Edge case
        if (String.IsNullOrEmpty(s)) return "";

        //Iterate through each char in the string and perform the check method twice - once for even length string
        //and once for odd length string
        for (int i = 0; i < s.Length; i++)
        {
            CheckPalindrome(i, i, s);
            CheckPalindrome(i, i + 1, s);
        }
        return s.Substring(resultIndex, resultLength);
    }
    public void CheckPalindrome(int left, int right, string s)
    {
        //While the left and right pointer are in bounds, and they are equal (it's palindromic)
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {  
            //If the current string is the longest, upgate the global variables             
            if (right - left + 1 > resultLength)
            {
                resultLength = right - left + 1;
                resultIndex = left;
            }
            //Shift pointers
            left--;
            right++;
        }
    }
}

//Old solution -----------------------------------------------------------------------------------------------------------
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
