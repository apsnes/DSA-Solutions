public class Solution {
    public int BuyChoco(int[] prices, int money)   {
        Array.Sort(prices);
        return prices[0] + prices[1] > money ? money : money - prices[0] - prices[1];
    }
}
