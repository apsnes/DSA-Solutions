public class Solution {
    public int MaxUniqueSplit(string s)
    {
        int ans = 0;
        HashSet<string> set = new();
        Backtrack(s, 0, set, 0, ref ans);
        return ans;
    }
    private void Backtrack(string s, int start, HashSet<string> set, int count, ref int ans)
    {
        if (count + (s.Length - start) <= ans) return;
        if (start == s.Length)
        {
            ans = Math.Max(ans, count);
            return;
        }
        for (int end = start + 1; end <= s.Length; ++end)
        {
            string substring = s.Substring(start, end - start);
            if (!set.Contains(substring))
            {
                set.Add(substring);
                Backtrack(s, end, set, count + 1, ref ans);
                set.Remove(substring);
            }
        }
    }
}
