public class Solution
{
    public string GetHappyString(int n, int k)
    {
        HashSet<string> strings = new();
        GenerateStrings(n, strings, "");
        List<string> ans = strings.ToList();
        ans.Sort();
        return ans.Count < k ? "" : ans[k - 1];
    }
    private void GenerateStrings(int n, HashSet<string> strings, string curr)
    {
        if (curr.Length == n)
        {
            strings.Add(curr);
            return;
        }
        if (curr.Length == 0 || curr.Length > 0 && curr[^1] != 'a')
        {
            GenerateStrings(n, strings, curr + "a");
        }
        if (curr.Length == 0 || curr.Length > 0 && curr[^1] != 'b')
        {
            GenerateStrings(n, strings, curr + "b");
        }
        if (curr.Length == 0 || curr.Length > 0 && curr[^1] != 'c')
        {
            GenerateStrings(n, strings, curr + "c");
        }
    }
}
