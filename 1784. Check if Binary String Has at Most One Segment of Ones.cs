public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        var parts = s.Split('0');
        return parts.Count(x => x.Length > 0) == 1;
    }
}
