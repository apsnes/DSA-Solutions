public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var ignore = new HashSet<int>();
        int left = 0, right = k - 1;
        var windowCount = nums.Length - k + 1;
        var res = new int[windowCount];
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < k; i++)
        {
            pq.Enqueue(i, -nums[i]);
        }

        for (int i = 0; i < windowCount; i++)
        {
            pq.TryPeek(out int maxIndex, out int maxNum);
            while (ignore.Contains(maxIndex))
            {
                pq.Dequeue();
                ignore.Remove(maxIndex);
                pq.TryPeek(out int currIndex, out int currNum);
                maxIndex = currIndex;
                maxNum = currNum;
            }
            res[i] = -maxNum;
            ignore.Add(left);
            left++;
            right++;
            if (i != windowCount - 1) pq.Enqueue(right, -nums[right]);
        }
        return res;
    }
}
