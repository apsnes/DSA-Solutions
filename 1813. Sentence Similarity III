public class Solution {
    public bool AreSentencesSimilar(string sentence1, string sentence2) {

        string[] s1Parts = sentence1.Split(' ');
        string[] s2Parts = sentence2.Split(' ');

        if (Enumerable.SequenceEqual(s1Parts, s2Parts)) return true;

        int n = s1Parts.Length;
        int m = s2Parts.Length;
        int min = Math.Min(n, m);
        List<string> prefix = new List<string>();
        List<string> suffix = new List<string>();

        for (int i = 0; i < min; i++)
        {
            if (s1Parts[i] == s2Parts[i])
            {
                prefix.Add(s1Parts[i]);
            }
            else
            {
                break;
            }
        }
        for (int i = 0; i < min; i++)
        {
            if (s1Parts[n - i - 1] == s2Parts[m - i - 1])
            {
                suffix.Add(s1Parts[n - i - 1]);
            }
            else
            {
                break;
            }
        }
        suffix.Reverse();

        while (suffix.Count + prefix.Count > min)
        {
            if (suffix.Count > 0 && prefix.Count > 0 && suffix[0] == prefix[prefix.Count - 1])
            {
                prefix.RemoveAt(prefix.Count - 1);
            }
            else
            {
                break;
            }
        }

        prefix.AddRange(suffix);

        return Enumerable.SequenceEqual(prefix, s1Parts) || Enumerable.SequenceEqual(prefix, s2Parts);
    }
}
