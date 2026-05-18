public class Solution
{
    public int MinJumps(int[] arr)
    {
        var n = arr.Length;
        Dictionary<int, List<int>> dict = new();
        HashSet<int> visited = new();
        for (int i = 0; i < arr.Length; i++)
        {
            var num = arr[i];
            if (!dict.ContainsKey(num)) dict[num] = new List<int>();
            dict[num].Add(i);
        }

        var q = new Queue<(int index, int jumps)>();
        q.Enqueue((0, 0));

        while(q.Count > 0)
        {
            (int index, int jumps) curr = q.Dequeue();
            if (visited.Contains(curr.index)) continue;
            if (curr.index == n - 1) return curr.jumps;
            if (curr.index + 1 < n) q.Enqueue((curr.index + 1, curr.jumps + 1));
            if (curr.index - 1 >= 0) q.Enqueue((curr.index - 1, curr.jumps + 1));
            foreach (var i in dict[arr[curr.index]])
            {
                q.Enqueue((i, curr.jumps + 1));
            }
            dict[arr[curr.index]].Clear();
            visited.Add(curr.index);
        }

        return -1;
    }
}
