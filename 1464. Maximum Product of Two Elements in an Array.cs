public class Solution {
    public int MaxProduct(int[] nums)
    {
        PriorityQueue<int, int> pq = new();

        foreach (int num in nums)
        {
            pq.Enqueue(num, 0 - num);
        }
        int one = pq.Dequeue() - 1;
        int two = pq.Dequeue() - 1;
        return one * two;
    }
}
