public class Solution
{
    public bool CanReach(int[] arr, int start)
    {
        var visited = new HashSet<int>();
        var q = new Queue<int>();
        q.Enqueue(start);

        while (q.Count > 0)
        {
            var curr = q.Dequeue();
            if (visited.Contains(curr)) continue;
            visited.Add(curr);
            var nextPlus = curr + arr[curr];
            var nextMinus = curr - arr[curr];
            if (nextPlus < arr.Length)
            {
                if (arr[nextPlus] == 0) return true;
                q.Enqueue(nextPlus);
            }
            if (nextMinus >= 0)
            {
                if (arr[nextMinus] == 0) return true;
                q.Enqueue(nextMinus);
            }
        }

        return false;
    }
}
