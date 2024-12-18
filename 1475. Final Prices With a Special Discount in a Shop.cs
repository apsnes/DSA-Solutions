public class Solution {
    public int[] FinalPrices(int[] prices)
    {
        for (int i = 0; i < prices.Length; i++)
        {
            int min = int.MaxValue;
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    min = prices[j];
                    break;
                }
            }
            if (min <= prices[i]) prices[i] = prices[i] - min;
        }
        return prices;
    }
}
