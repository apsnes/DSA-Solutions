public class Solution {
    public string ReverseWords(string s)
    {
        string[] parts = s.Split(' ');
        Array.Reverse(parts);
        IEnumerable<string> res = parts.Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x));
        return String.Join(' ', res);
    }
}
