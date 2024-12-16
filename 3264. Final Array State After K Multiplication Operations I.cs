public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        PriorityQueue<int, (int, int)> pq = new(
        Comparer<(int, int)>.Create((a, b) =>
        {
            return a.Item1 == b.Item1
                ? a.Item2.CompareTo(b.Item2)
                : a.Item1.CompareTo(b.Item1);
        }));
        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(i, (nums[i], i));
        }
        for (int i = 0; i < k; i++)
        {
            var index = pq.Dequeue();
            nums[index] *= multiplier;
            pq.Enqueue(index, (nums[index], index));
        }
        return nums;
    }
}
