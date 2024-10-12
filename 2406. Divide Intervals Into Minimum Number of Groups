public class Solution {
    public int MinGroups(int[][] intervals)
    {
        PriorityQueue<int, int> pq = new();
        int ans = 0;

        Array.Sort(intervals, Comparer<int[]>.Create((a, b) => a[0] - b[0]));

        int prevMax = 0;
        for (int i = 0; i < intervals.Length; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];

            while (pq.Count > 0 && pq.Peek() < start)
            {
                pq.Dequeue();
            }
            pq.Enqueue(end, end);
            ans = Math.Max(ans, pq.Count);
        }
        return ans;
    }
}
