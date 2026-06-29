public class Solution
{
    public int NumOfStrings(string[] patterns, string word)
    {
        var res = 0;
        foreach (var pattern in patterns)
        {
            if (word.Contains(pattern)) res++;
        }
        return res;
    }
}
