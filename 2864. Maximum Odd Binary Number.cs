public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        var zero = 0;
        var one = 0;
        foreach (var c in s)
        {
            if (c == '0') zero++;
            if (c == '1') one++;
        }
        var sb = new StringBuilder();
        for (int i = 0; i < one - 1; i++) sb.Append('1');
        for (int i = 0; i < zero; i++) sb.Append('0');
        sb.Append('1');
        return sb.ToString();
    }
}
