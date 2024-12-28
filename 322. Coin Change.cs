public class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        //DP cache to store already computed values
        Dictionary<int, int> cache = new();
        //Set cache[0] to 0, indicating that if our remaining balance is 0, we need 0 coins
        cache[0] = 0;
        int minCoins = numberOfCoins(coins, amount, cache);
        //Check if we found a way to reach the required amount, if not, return -1
        return minCoins == int.MaxValue ? -1 : minCoins;
    }
    public int numberOfCoins(int[] coins, int remainingAmount, Dictionary<int, int> cache)
    {
        //If we've already computed this remaining amount, return the previously computed value
        if (cache.ContainsKey(remainingAmount)) return cache[remainingAmount];
        int minCoins = int.MaxValue;
        //Check each coin to see which coin gives us the best result for the current remaining amount
        foreach (int coin in coins)
        {
            //If the coin is small enough to not make our remaining balance negative
            if (remainingAmount - coin >= 0)
            {
                //Compute the coins required for the current coin and remaining balance
                int currentAns = numberOfCoins(coins, remainingAmount - coin, cache);
                //If the current required amount is less than int.MaxValue, then we found a possible way. Check if
                //this is the fewest required coins so far for the current remaining amound and update the var if so
                if (currentAns != int.MaxValue) minCoins = Math.Min(minCoins, 1 + currentAns);
            }
        }
        //Store the computed result in dp cache to prevent future redundant computation
        cache[remainingAmount] = minCoins;
        return minCoins;
    }
}
