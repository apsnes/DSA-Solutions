/*Approach
Add counts of each process to a dictionary. Enqueue the counts of each process with the priority being 0 - count, so that the priotity queue prioritises the largest value.

Create a queue to store the process which are currently on 'cooldown', along with the time that they will be off cooldown.

While the priority queue or the queue are not empty, increment time by one, take the most frequently occuring process from the front of the priority queue, and 'process' it by reducing its value by one. If the resulting value is greater than 1, there are more processes to be made, so we add it to the cooldown queue along with the time that it will be off cooldown (time + n). At the end of the loop, check to see if the process at the front of the queue is off cooldown and if it is, Enqueue it back to the priority queue.

Return the total time taken to remove all processes from the queues.*/

public class Solution {
    public int LeastInterval(char[] tasks, int n)
    {
        int time = 0;
        PriorityQueue<int, int> pq = new();
        Dictionary<char, int> dict = new();
        foreach (char c in tasks)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach(var entry in dict)
        {
            pq.Enqueue(entry.Value, -entry.Value);
        }

        Queue<(int, int)> queue = new();

        while (pq.Count > 0 || queue.Count > 0)
        {
            time++;
            if (pq.Count > 0)
            {
                int curr = pq.Dequeue();
                curr--;
                if (curr > 0)
                {
                    queue.Enqueue((curr, time + n));
                }
            }
            if (queue.Count > 0 && queue.Peek().Item2 == time)
            {
                var top = queue.Dequeue();
                pq.Enqueue(top.Item1, -top.Item1);
            }
        }
        return time;
    }
}
