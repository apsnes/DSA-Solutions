public class Solution
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var dict = knowledge.ToDictionary(x => x[0]);

        var sb = new StringBuilder();
        var i = 0;

        while (i < s.Length)
        {
            if (s[i] != '(')
            {
                sb.Append(s[i]);
                i++;
            }
            else
            {
                var closeBracket = -1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == ')')
                    {
                        closeBracket = j;
                        break;
                    }
                }
                var newString = ExtractValue(s.Substring(i + 1, closeBracket - i - 1), dict);
                sb.Append(newString);
                i = closeBracket + 1;
            }
        }
        return sb.ToString();
    }

    private string ExtractValue (string input, Dictionary<string, IList<string>> dict)
    {
        if (dict.ContainsKey(input)) return dict[input][1];
        else return "?";
    }
}
