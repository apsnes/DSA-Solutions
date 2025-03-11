public class Solution
{
    Dictionary<char, int> freq;

    public int NumberOfSubstrings(string s)
    {
        int left = 0, right = 0;
        freq = new();
        int ans = 0;
        while (right < s.Length && left <= right)
        {
            char curr = s[right];
            if (!freq.ContainsKey(curr)) freq[curr] = 0;
            freq[curr]++;
            while (hasChars())
            {
                ans += s.Length - right;
                freq[s[left]]--;
                if (freq[s[left]] == 0) freq.Remove(s[left]);
                left++;
            }
            right++;
        }
        return ans;
    }
    private bool hasChars()
    {
        return freq.ContainsKey('a') && freq.ContainsKey('b') && freq.ContainsKey('c');
    }
}
