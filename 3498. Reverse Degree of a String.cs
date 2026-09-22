public class Solution
{
    public int ReverseDegree(string s)
    {
        var res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var indexValue = i + 1;
            var currChar = s[i];
            var charVal = 26 - (currChar - 'a');
            res += charVal * indexValue;
        }
        return res;
    }
}
