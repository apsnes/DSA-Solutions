public class Solution {
    public long MinimumSteps(string s)
    {
        long count = 0;
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                count += i - j;
                j++;
            }
        }
        return count;
    }
}
