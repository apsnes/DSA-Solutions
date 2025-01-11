public class Solution {
    public bool CanConstruct(string s, int k)
    {
        if (k == s.Length) return true;
        if (k >  s.Length) return false;
        Dictionary<char, int> charCounts = new();
        foreach (char c in s)
        {
            if (!charCounts.ContainsKey(c)) charCounts[c] = 0;
            charCounts[c]++;
        }
        int oddCount = 0;
        foreach (var entry in charCounts)
        {
            if (entry.Value % 2 != 0)
            {
                oddCount++;
            } 
        }
        return oddCount <= k ? true : false;
    }
}
