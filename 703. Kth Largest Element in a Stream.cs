public class KthLargest {

    PriorityQueue<int, int> queue;
    int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        queue = new();

        foreach (int num in nums)
        {
            Add(num);
        }
    }
    
    public int Add(int val) {
        
        queue.Enqueue(val, val);

        while (queue.Count > k)
        {
            queue.Dequeue();
        }

        return queue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
