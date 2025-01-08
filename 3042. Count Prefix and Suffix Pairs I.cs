public class Solution
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (isPrefixAndSuffix(words[i], words[j])) count++;
            }
        }
        return count;
    }
    private bool isPrefixAndSuffix(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;
        if (s2.StartsWith(s1) && s2.EndsWith(s1)) return true;
        return false;
    }
}
