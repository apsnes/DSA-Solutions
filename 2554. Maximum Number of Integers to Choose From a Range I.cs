public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        int sum = 0;
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (banned.Contains(i)) continue;
            sum+= i;
            if (sum > maxSum) break;
            count++;
        }
        return count;
    }
}
