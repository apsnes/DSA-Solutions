/*Add all values to the priority queue, ordered by 0 - num. This ensures the maximum value is at the 'front' of the queue.
Iterate from 0 to k, at each step dequeueing the maximum value and adding it the score.
Take the ceiling of (currentValue / 3) and add it back to the priority queue.*/

public class Solution {
    public long MaxKelements(int[] nums, int k) {
        long score = 0;
        PriorityQueue<int, int> pq = new();
        foreach (int num in nums)
        {
            pq.Enqueue(num, 0 - num);
        }
        int i = 0;
        while (i < k && pq.Count > 0)
        {
            int curr = pq.Dequeue();
            score += curr;
            curr = (int)Math.Ceiling((curr * 1.0) / 3);
            pq.Enqueue(curr, 0 - curr);
            i++;        
        }
        return score;
    }
}
