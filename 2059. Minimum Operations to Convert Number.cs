public class Solution
{
    public int MinimumOperations(int[] nums, int start, int goal)
    {
        var q = new Queue<(int Num, int Operations)>();
        q.Enqueue((start, 0));
        var seen = new HashSet<int>();
        while(q.Count > 0)
        {
            var curr = q.Dequeue();
            if (curr.Num == goal) return curr.Operations;
            if (seen.Contains(curr.Num) || curr.Num > 1000 || curr.Num < 0) continue;
            seen.Add(curr.Num);
            foreach (var num in nums)
            {
                q.Enqueue((curr.Num + num, curr.Operations + 1));
                q.Enqueue((curr.Num - num, curr.Operations + 1));
                q.Enqueue((curr.Num ^ num, curr.Operations + 1));
            }
        }
        return -1;
    }
}
