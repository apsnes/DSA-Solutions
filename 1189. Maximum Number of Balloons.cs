// Dictionary
public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in text)
        {
            if (!dict.ContainsKey(c)) dict[c] = 0;
            dict[c]++;
        }

        if (!dict.ContainsKey('b') || !dict.ContainsKey('a') || !dict.ContainsKey('n') || !dict.ContainsKey('o') || !dict.ContainsKey('l'))
            return 0;

        var res = int.MaxValue;
        res = Math.Min(res, dict['b']);
        res = Math.Min(res, dict['a']);
        res = Math.Min(res, dict['n']);
        res = Math.Min(res, dict['o'] / 2);
        res = Math.Min(res, dict['l'] / 2);
        return res;
    }
}

// Count
public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        int b = 0, a = 0, l = 0, o = 0, n = 0;
        var res = 0;
        foreach (var c in text)
        {
            if (c == 'b') b++;
            if (c == 'a') a++;
            if (c == 'l') l++;
            if (c == 'o') o++;
            if (c == 'n') n++;

            if (b >= 1 && a >= 1 && l >= 2 && o >= 2 && n >= 1)
            {
                res++;
                b--;
                a--;
                l -= 2;
                o -= 2;
                n--;
            }
        }
        return res;
    }
}
