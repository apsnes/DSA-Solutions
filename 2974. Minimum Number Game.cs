public class Solution {
    public int[] NumberGame(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[nums.Length];
        PriorityQueue<int, int> pq = new();
        foreach (int num in nums)
        {
            pq.Enqueue(num, num);
        }
        int count = pq.Count;
        for (int i = 0; i < count; i++)
        {
            int alice = pq.Dequeue();
            int bob = pq.Dequeue();
            ans[i] = bob;
            i++;
            ans[i] = alice;
        }
        return ans;
    }
}
