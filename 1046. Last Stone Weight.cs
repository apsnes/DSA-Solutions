public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>();

        for (int i = 0; i < stones.Length; i++)
        {
            pq.Enqueue(stones[i], 0 - stones[i]);
        }

        while(pq.Count > 1)
        {
            var stone1 = pq.Dequeue();
            var stone2= pq.Dequeue();

            if (stone1 == stone2) continue;
            var maxStone = Math.Max(stone1, stone2);
            var minStone = Math.Min(stone1, stone2);

            var newStone = maxStone - minStone;
            pq.Enqueue(newStone, 0 - newStone);
        }
        return pq.Count == 1 ? pq.Dequeue() : 0;
    }
}
