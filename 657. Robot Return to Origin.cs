public class Solution 
{
    public bool JudgeCircle(string moves)
    {
        var pos = (0, 0);
        foreach (char c in moves)
        {
            if (c == 'L') pos.Item2--;
            if (c == 'R') pos.Item2++;
            if (c == 'U') pos.Item1--;
            if (c == 'D') pos.Item1++;
        }
        return pos == (0, 0);
    }
}
