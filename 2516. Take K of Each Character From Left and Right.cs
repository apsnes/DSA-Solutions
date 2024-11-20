public class Solution {
    public int TakeCharacters(string s, int k)
    {
        Dictionary<char, int> count = new();
        count['a'] = 0; count['b'] = 0; count['c'] = 0;
        foreach(char c in s)
        {
            count[c]++;
        }
        if (count['a'] < k || count['b'] < k || count['c'] < k) return -1;

        int minutes = int.MaxValue;
        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            count[s[right]]--;
            
            while (count['a'] < k || count['b'] < k || count['c'] < k)
            {
                count[s[left]]++;
                left++;
            }
            minutes = Math.Min(minutes, s.Length - (right - left + 1));
        }
        return minutes;
    }
}
