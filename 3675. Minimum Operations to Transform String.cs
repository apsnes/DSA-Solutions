public class Solution
{
    public int MinOperations(string s)
    {
        if (s.Length == 1 && s[0] == 'a') return 0;
        if (s.Length == 1) return 'z' - s[0] + 1;
        var res = 0;
        var cArr = s.ToCharArray();
        cArr.Sort();
        var n = cArr.Length;

        for (int i = 0; i < n; i++)
        {
            var curr = cArr[i];
            if (curr == 'a') continue;
            if (i + 1 < n)
            {
                var next = cArr[i + 1];
                if (curr == next) continue;
                res += next - curr;
            } 
            else
            {
                if (curr != 'a')
                {
                    res += 'z' - curr + 1;
                }
            }
        }

        return res;
    }
}
