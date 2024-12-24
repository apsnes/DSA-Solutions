public class Solution {
    public int MaximumLengthSubstring(string s)
    {
        int maxLen = 0;
        Dictionary<char, int> dict = new();
        dict[s[0]] = 1;
        for (int i = 0, j = 1; j < s.Length; j++)
        {
            if(!dict.ContainsKey(s[j])) dict[s[j]] = 0;
            dict[s[j]]++;
            while(dict[s[j]] > 2)
            {
                dict[s[i]]--;
                if (dict[s[i]] == 0)
                {
                    dict.Remove(s[i]);
                }
                i++;
            }
            maxLen = Math.Max(maxLen, j - i + 1);
        }
        return maxLen;
    }
}
