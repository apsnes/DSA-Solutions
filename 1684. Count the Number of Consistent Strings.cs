public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int allowedMask = 0;
        foreach (char c in allowed)
        {
            allowedMask |= (1 << (c - 'a'));
        }
        int ans = 0;
        foreach (string word in words)
        {
            int mask = 0;
            foreach (char c in word)
            {
                mask |= (1 << (c - 'a'));
            }
            if ((mask & allowedMask) == mask)
            {
                ans++;
            }
        }
        return ans;
    }
}
