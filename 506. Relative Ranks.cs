public class Solution {
    public string[] FindRelativeRanks(int[] score)
    {
        PriorityQueue<int, int> pq = new();
        string[] ans = new string[score.Length];
        int n = score.Length;

        for (int i = 0; i < n; i++)
        {
            pq.Enqueue(i, 0 - score[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                ans[pq.Dequeue()] = "Gold Medal";
            }
            else if (i == 1)
            {
                ans[pq.Dequeue()] = "Silver Medal";
            }
            else if (i == 2)
            {
                ans[pq.Dequeue()] = "Bronze Medal";
            }
            else
            {
                ans[pq.Dequeue()] = (i + 1).ToString();
            }
        }
        return ans;
    }
}
