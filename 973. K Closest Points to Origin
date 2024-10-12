public class Solution {
    public int[][] KClosest(int[][] points, int k)
    {
        int n = points.Length;
        int[][] ans = new int[k][];
        PriorityQueue<int[], int> pq = new();

        for (int i = 0; i < n; i++)
        {
            int x = points[i][0];
            int y = points[i][1];
            int distance = (x * x) + (y * y);
            int[] toAdd = [x, y];
            pq.Enqueue(toAdd, distance);
        }
        for (int i = 0; i < k; i++)
        {
            ans[i] = pq.Dequeue();
        }
        return ans;
    }
}
