public class MedianFinder {

    private PriorityQueue<int, int> leftQueue;
    private PriorityQueue<int, int> rightQueue;

    public MedianFinder()
    {
        leftQueue = new PriorityQueue<int, int>();
        rightQueue = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num)
    {
        leftQueue.Enqueue(num, -num);
        int val = 0;
        if (rightQueue.Count > 0 && leftQueue.Peek() > rightQueue.Peek())
        {
            val = leftQueue.Dequeue();
            rightQueue.Enqueue(val, val);
        }
        if (leftQueue.Count > rightQueue.Count + 1)
        {
            val = leftQueue.Dequeue();
            rightQueue.Enqueue(val, val);
        }
        else if (rightQueue.Count > leftQueue.Count + 1)
        {
            val = rightQueue.Dequeue();
            leftQueue.Enqueue(val, -val);
        }
    }
    
    public double FindMedian()
    {
        if (leftQueue.Count > rightQueue.Count)
        {
            return leftQueue.Peek();
        }
        if (rightQueue.Count > leftQueue.Count)
        {
            return rightQueue.Peek();
        }
        else
        {
            return (double)(leftQueue.Peek() + rightQueue.Peek()) / 2;
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
