public class Solution {
    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int num in stones)
        {
            pq.Enqueue(num, 0 - num);
        }

        while (pq.Count > 1)
        {
            int y = pq.Dequeue();
            int x = pq.Dequeue();

            if (x == y)
            {
                continue;
            }
            else
            {
                y = y - x;
            }
            if (y > 0)
            {
                pq.Enqueue(y, 0 - y);
            }
        }
        return pq.Count > 0 ? pq.Dequeue() : 0;
    }
}
