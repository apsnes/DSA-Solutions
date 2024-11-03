public class Solution {
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
        {
            return false;
        }
        string together = s + s;
        int n = goal.Length;
        for (int i = 0; i < together.Length - n; i++)
        {
            if (together[i] == goal[0])
            {
                bool found = true;
                for (int j = 1; j < n; j++)
                {
                    if (together[i + j] != goal[j])
                    {
                        found = false;
                    }
                }
                if (found == true)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
