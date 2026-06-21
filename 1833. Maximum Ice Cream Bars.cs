// Counting sort algorithm

public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        var n = costs.Length;
        // Find max number in input array
        var max = costs[0];
        for (int i = 1; i < n; i++) max = Math.Max(max, costs[i]);

        // Fill freq arr of numbers in input array
        var freq = new int[max + 1];
        foreach (var cost in costs) freq[cost]++;

        // Fill acc arr - array adding up the sum of all previous elements (accumulating)
        var acc = new int[max + 1];
        acc[0] = freq[0];
        for (int i = 1; i < acc.Length; i++) acc[i] = acc[i - 1] + freq[i];

        // Fill index arr - create an array consisting of the start index for each num in the input array. When placing a number in the output array, increment the start index by 1.
        var ind = new int[max + 1];
        ind[0] = 0;
        for (int i = 1; i < ind.Length; i++) ind[i] = acc[i - 1];

        // Fill sorted answer arr by iterating through the input and finding the start index for each num and placing it at that index in the output. Increment that numbers start index.
        var ans = new int[n];
        foreach (var cost in costs)
        {
            var ansIndex = ind[cost];
            ans[ansIndex] = cost;
            ind[cost]++;
        }

        // Use ans arr to use up coins to buy ice cream until coins run out
        var maxIceCream = 0;
        foreach (var cost in ans)
        {
            if (coins < cost) break;
            coins -= cost;
            maxIceCream++;
        }
        return maxIceCream;
    }
}
