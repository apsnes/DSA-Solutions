public class Solution
{
    public int MinNumberOfFrogs(string croakOfFrogs)
    {
        var ongoing = 0;
        var maxOngoing = 0;
        var croaks = new Dictionary<char, int>();
        var chars = new char[5] { 'c', 'r', 'o', 'a', 'k' };
        foreach (var c in chars) croaks[c] = 0;

        for (int i = 0; i < croakOfFrogs.Length; i++)
        {
            var curr = croakOfFrogs[i];
            if (!croaks.ContainsKey(curr)) return -1;
            croaks[curr]++;
            if (curr == 'c')
            {
                ongoing++;
                maxOngoing = Math.Max(ongoing, maxOngoing);
            }
            if (curr == 'r' && croaks['c'] < croaks['r']) return -1;
            if (curr == 'o' && croaks['r'] < croaks['o']) return -1;
            if (curr == 'a' && croaks['o'] < croaks['a']) return -1;
            if (curr == 'k' && croaks['a'] < croaks['k']) return -1;
            else if (curr == 'k') ongoing--;
        }

        return ongoing == 0 ? maxOngoing : -1;
    }
}
