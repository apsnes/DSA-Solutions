public class Solution {
    public long MinEnd(int n, int x)
    {
        long ans = x;;
        for (int i = 1; i < n; i++)
        {
            ans++;
            ans |= x;
        }
        return ans;
    }
}
