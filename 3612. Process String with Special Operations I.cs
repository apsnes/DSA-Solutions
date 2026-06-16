public class Solution
{
    public string ProcessStr(string s)
    {
        var str = string.Empty;
        foreach (var c in s)
        {
            if (char.IsLower(c)) str = str + c;
            if (string.IsNullOrEmpty(str)) continue;
            if (c == '*') str = str.Substring(0, str.Length - 1);
            if (c == '#') str = str + str;
            if (c == '%') str = new string(str.Reverse().ToArray());
        }
        return str;
    }
}
