public class Solution
{
    public bool CanReach(string s, int minJump, int maxJump)
    {
        if (s[^1] != '0') return false;
        var longestSequence = LongestSequence(s);
        if (longestSequence >= maxJump) return false;
        HashSet<int> visited = new();
        return Dfs(s, 0, visited, minJump, maxJump);
    }

    private bool Dfs(string s, int index, HashSet<int> visited, int minJump, int maxJump)
    {
        visited.Add(index);
        if (s[index] != '0') return false;
        if (index == s.Length - 1) return true;

        for (int i = index + minJump; i < s.Length; i++)
        {
            if (i <= index + maxJump && !visited.Contains(i) && s[i] == '0')
            {
                if (Dfs(s, i, visited, minJump, maxJump)) return true;
            }
        }

        return false;
    }

    private int LongestSequence(string s)
    {
        var max = 0;
        var curr = 0;
        var i = 1;

        while (i < s.Length)
        {
            if (s[i] == '1') curr++;
            else
            {
                max = Math.Max(max, curr);
                curr = 0;
            }
            i++;
        }
        return max;
    }
}
