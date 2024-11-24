public class Solution {
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int> { 
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };
        int n = s.Length;
        int result = dict[s[n - 1]];
        for (int i = n - 2; i >= 0; i--)
        {
            if (dict[s[i]] < dict[s[i + 1]]) result -= dict[s[i]];
            else result += dict[s[i]];
        }
        return result;
    }
}
