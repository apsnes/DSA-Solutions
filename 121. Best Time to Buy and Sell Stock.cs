public class Solution {
    public int MaxProfit(int[] prices)
    {
        int maxDifference = 0;
        int left = 0;
        int right = 1;
        while (right < prices.Length)
        {
            if (prices[right] < prices[left])           
            {
                left = right;
                right++;
            }
            else 
            {
                maxDifference = Math.Max(maxDifference, prices[right] - prices[left]);
                right++;
            }
        }
        return maxDifference;
    }
}
