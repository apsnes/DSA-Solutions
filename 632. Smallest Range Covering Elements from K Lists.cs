public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        PriorityQueue<int[], int> pq = new();

        int start = -1;
        int end = nums[0][0];
        int range = int.MaxValue;

        for (int i = 0; i < nums.Count; i++)
        {
            end = Math.Max(end, nums[i][0]);
            pq.Enqueue([nums[i][0], i, 0], nums[i][0]);
        }

        while (pq.Count == nums.Count)
        {
            var val = pq.Dequeue();
            var (num, i, c) = (val[0], val[1], val[2]);

            if (end - num < range)
            {
                start = num;
                range = end - num;
            }

            if (c + 1 == nums[i].Count)
            {
                break;
            }
            pq.Enqueue([nums[i][c + 1], i, c + 1], nums[i][c + 1]);
            end = Math.Max(end, nums[i][c + 1]);
        }
        return [start, start + range];
    }
}
