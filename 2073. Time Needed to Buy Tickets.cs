public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int total = tickets[k];
        for (int i = 0; i < k; i++)
        {
            if (tickets[i] > tickets[k]) tickets[i] = tickets[k];
            total += tickets[i];
        }
        for (int i = k + 1; i < tickets.Length; i++)
        {
            if (tickets[i] > tickets[k] - 1) tickets[i] = tickets[k] - 1;
            total += tickets[i];
        }
        return total;
    }
}
