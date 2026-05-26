public class Solution
{
    public int NumberOfSpecialChars(string word)
    {
        var set = new HashSet<char>();
        var count = 0;

        foreach (char c in word)
        {
            if (set.Contains(c)) continue;
            set.Add(c);
            if (char.IsLower(c) && set.Contains(char.ToUpper(c))) count++;
            if (char.IsUpper(c) && set.Contains(char.ToLower(c))) count++;
        }
        return count;
    }
}


public class Solution
{
    public int NumberOfSpecialChars(string word)
    {
        var set = new HashSet<char>(word);
        var count = 0;

        foreach (char c in word)
        {
            if (char.IsLower(c) && set.Contains(char.ToUpper(c)))
            {
                count++;
                set.Remove(c);
                set.Remove(char.ToUpper(c));
            }
            if (char.IsUpper(c) && set.Contains(char.ToLower(c)))
            {
                count++;
                set.Remove(c);
                set.Remove(char.ToLower(c));
            }        
        }
        return count;
    }
}
