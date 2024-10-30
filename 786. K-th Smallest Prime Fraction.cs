public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        PriorityQueue<(int, int), double> pq = new();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                var val = (double) arr[i] / arr[j];
                pq.Enqueue((arr[i], arr[j]), 0 - val);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
        }
        return new int[] {pq.Peek().Item1, pq.Peek().Item2};
    }
}
