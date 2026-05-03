public class Solution 
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        var firstChar = goal[0];
        var together = s + s;
        for (int i = 0; i < together.Length; i++)
        {
            if (i + goal.Length >= together.Length) break;
            if (together[i] == firstChar)
            {
                var found = true;
                var index = 1;
                for (int j = 1; j < goal.Length; j++)
                {
                    if (together[i + j] == goal[index]) index++;
                    else
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return true;
            }
        }
        return false;
    }
}
