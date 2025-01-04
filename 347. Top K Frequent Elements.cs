//Priority Queue solution
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        //Dictionary to store counts of each number
        Dictionary<int, int> counts = new();
        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts[num] = 0;
            counts[num]++;
        }
        //Create priority queue and enqueue all numbers, prioritised by their counts with the highest count first
        PriorityQueue<int, int> pq = new();
        foreach (var entry in counts)
        {
            pq.Enqueue(entry.Key, 0 - entry.Value);
        }
        //Initiate our answer array
        int[] ans = new int[k];
        for (int i = 0; i < k; i++)
        {
            //Dequeue k total numbers and add them to our answer array
            ans[i] = pq.Dequeue();
        }
        return ans;
    }
}
