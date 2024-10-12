public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        PriorityQueue<int, int> outgoing = new();
        PriorityQueue<int, int> chairQueue = new();
        int targetArrival = times[targetFriend][0];

        Array.Sort(times, (a, b) => a[0].CompareTo(b[0]));

        foreach (int[] time in times)
        {
            while (outgoing.TryPeek(out int chair, out int leaving) && leaving <= time[0])
            {
                chairQueue.Enqueue(chair, chair);
                outgoing.Dequeue();
            }

            if (chairQueue.Count == 0)
            {
                chairQueue.Enqueue(outgoing.Count, outgoing.Count);
            }
            if (time[0] == targetArrival)
            {
                break;
            }
            outgoing.Enqueue(chairQueue.Dequeue(), time[1]);
        }
        return chairQueue.Peek();
    }
}
