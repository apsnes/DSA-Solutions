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



public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        if (s.Length == 1) return 0;
        int a = 0, b = 0, c = 0;
        int left = 0, right = 0;
        var res = 0;

        while (right < s.Length)
        {
            if (s[right] == 'a') a++;
            if (s[right] == 'b') b++;
            if (s[right] == 'c') c++;

            while (a > 0 && b > 0 && c > 0)
            {
                res += s.Length - right;
                if (s[left] == 'a') a--;
                if (s[left] == 'b') b--;
                if (s[left] == 'c') c--;
                left++;
            }
            right++;
        }

        return res;
    }
}
