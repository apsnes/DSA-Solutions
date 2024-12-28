public class Solution
{
    //Var to keep track of total palindromic substrings
    int palindromeCount = 0;

    public int CountSubstrings(string s)
    {
        //Base case
        if (String.IsNullOrEmpty(s)) return 0;

        //Iterate through string and perform palindrome checker function on each index twice - once to check for odd
        //length substrings and once to check for even length substrings
        for (int i = 0; i < s.Length; i++)
        {
            //Checks odd
            CheckPalindrome(i, i, s);
            //Checks even
            CheckPalindrome(i, i + 1, s);
        }
        return palindromeCount;
    }
    public void CheckPalindrome(int left, int right, string s)
    {
        //While indicies are in bounds and still palindromic, shift indexes and increase palindromeCount 
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
            palindromeCount++;
        }
    }
}
