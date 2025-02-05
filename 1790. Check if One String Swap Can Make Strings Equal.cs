public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;
        List<int> indexes = new();
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                indexes.Add(i);
            }
            if (indexes.Count > 2) return false;
        }
        if (indexes.Count == 1) return false;
        if (indexes.Count == 2)
        {
            if (s2[indexes[0]] != s1[indexes[1]] || s2[indexes[1]] != s1[indexes[0]]) return false;
        }
        return true;
    }
}
