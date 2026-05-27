public class Solution
{
    public int NumberOfSpecialChars(string word)
    {
        var dict = new Dictionary<int, int[]>();

        for (int i = 0; i < word.Length; i++)
        {
            var curr = word[i];
            var currKey = char.IsLower(curr) ? curr - 'a' : curr - 'A';
            if (!dict.ContainsKey(currKey))
            {
                dict[currKey] = new int[2];
                Array.Fill(dict[currKey], -1);
            }
            if (char.IsUpper(curr) && dict[currKey][1] == -1)
            {
                dict[currKey][1] = i;
            }
            if (char.IsLower(curr))
            {
                dict[currKey][0] = i;
            }
        }
        return dict.Count(x => x.Value[0] != -1 && x.Value[1] != -1 && x.Value[0] < x.Value[1]);
    }
}
