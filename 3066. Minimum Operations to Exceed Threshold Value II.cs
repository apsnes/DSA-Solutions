public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        PriorityQueue<long, long> pq = new();
        foreach (int num in nums)
        {
            pq.Enqueue(num, num);
        }
        int operations = 0;
        while (pq.Peek() < k)
        {
            long currMin = pq.Dequeue();
            long currSecondMin = pq.Dequeue();
            currMin = currMin * 2;
            long currRes = currMin + currSecondMin;
            pq.Enqueue(currRes, currRes);
            operations++;
        }
        return operations;
    }
}
