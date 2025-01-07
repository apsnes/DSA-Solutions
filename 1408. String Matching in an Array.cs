public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        List<string> res = new();
        for (int i = 0; i < words.Length; i++)
        {
            int[] lps = createLPSArray(words[i]);
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j) continue;
                if (checkSubstring(words[i], words[j], lps))
                {
                    res.Add(words[i]);
                    break;
                }
            }
        }
        return res;
    }
    private int[] createLPSArray(string s)
    {
        int[] lps = new int[s.Length];
        int index = 1;
        int len = 0;
        while (index < s.Length)
        {
            if (s[index] == s[len])
            {
                len++;
                lps[index] = len;
                index++;
            }
            else
            {
                if (len > 0) len = lps[len - 1];
                else index++;
            }
        }
        return lps;
    }
    private bool checkSubstring(string sub, string s, int[] lps)
    {
        int i = 0;
        int j = 0;
        while (i < s.Length)
        {
            if (s[i] == sub[j])
            {
                i++;
                j++;
                if (j == sub.Length) return true;
            }
            else
            {
                if (j > 0) j = lps[j - 1];
                else i++;
            }
        }
        return false;
    }
}
