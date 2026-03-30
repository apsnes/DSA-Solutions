// Multiple Dictionary Solution
public class Solution
{
    public bool CheckStrings(string s1, string s2)
    {
        var s1EvenIndexChars = new Dictionary<char, int>();
        var s1OddIndexChars = new Dictionary<char, int>();
        var s2EvenIndexChars = new Dictionary<char, int>();
        var s2OddIndexChars = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (!s1EvenIndexChars.ContainsKey(s1[i])) s1EvenIndexChars[s1[i]] = 0;
                s1EvenIndexChars[s1[i]]++;
                if (!s2EvenIndexChars.ContainsKey(s2[i])) s2EvenIndexChars[s2[i]] = 0;
                s2EvenIndexChars[s2[i]]++;
            }
            else
            {
                if (!s1OddIndexChars.ContainsKey(s1[i])) s1OddIndexChars[s1[i]] = 0;
                s1OddIndexChars[s1[i]]++;
                if (!s2OddIndexChars.ContainsKey(s2[i])) s2OddIndexChars[s2[i]] = 0;
                s2OddIndexChars[s2[i]]++;
            }
        }
        foreach (var kvp in s1EvenIndexChars)
        {
            if (!s2EvenIndexChars.ContainsKey(kvp.Key) || s2EvenIndexChars[kvp.Key] != kvp.Value) return false;
        }
        foreach (var kvp in s1OddIndexChars)
        {
            if (!s2OddIndexChars.ContainsKey(kvp.Key) || s2OddIndexChars[kvp.Key] != kvp.Value) return false;
        }
        return true;
    }
}

// Optimised Single Dictionary Solution
public class Solution
{
    public bool CheckStrings(string s1, string s2)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < s1.Length; i++)
        {
            var offset = (i & 1) << 7;
            var s1Key = s1[i] + offset;
            var s2Key = s2[i] + offset;
            if (!dict.ContainsKey(s1Key)) dict[s1Key] = 0;
            if (!dict.ContainsKey(s2Key)) dict[s2Key] = 0;
            dict[s1Key]++;
            dict[s2Key]--;
        }
        
        foreach (var kvp in dict)
        {
            if (kvp.Value != 0) return false;
        }

        return true;
    }
}
