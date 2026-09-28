public class Solution
{
    public int MaxDepth(string s)
    {
        var max = 0;
        var current = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                current++;
                max = Math.Max(max, current);
            }
            if (c == ')')
            {
                current--;
            }
        }
        return max;
    }
}
