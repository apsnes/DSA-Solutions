// stack-like (optimised)
public class Solution
{
    public string ClearDigits(string s)
    {
        StringBuilder sb = new();
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                sb.Length--;
                continue;
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}

// iteration:
public class Solution
{
    public string ClearDigits(string s)
    {
        while (true)
        {
            if (!s.Any(char.IsDigit)) break;
            else s = RemoveDigit(s);
        }
        return s;
    }

    private string RemoveDigit(string s)
    {
        int lastCharIndex = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsDigit(s[i]))
            {
                lastCharIndex = i;
                continue;
            }
            s = s.Remove(i, 1);
            if (lastCharIndex != -1)
            {
                s = s.Remove(lastCharIndex, 1);
                break;
            }
        }
        return s;
    }
}
