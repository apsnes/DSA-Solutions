public class Solution
{
    public int MinimumLength(string s)
    {
        int wordLength = s.Length;
        int[] charCounts = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
            if (charCounts[s[i] - 'a'] != 1 && charCounts[s[i] - 'a'] % 2 == 1)
            {
                wordLength -= 2;
            }
        }
        return wordLength;
    }
}
