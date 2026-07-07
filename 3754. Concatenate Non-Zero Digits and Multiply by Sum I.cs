public class Solution
{
    public long SumAndMultiply(int n)
    {
        if (n == 0) return 0;
        var str = n.ToString();
        str = str.Replace("0", "");
        long sum = 0;
        foreach (var c in str) sum += int.Parse(c.ToString());
        return long.Parse(str) * sum;
    }
}
