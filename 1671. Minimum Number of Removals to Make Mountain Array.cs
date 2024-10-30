public class Solution {
    public int MinimumMountainRemovals(int[] nums)
    {
        var n = nums.Length;
        var ans = 0;
        for (var i = 1; i < n-1; i++)
        {
            var lisLength = Increasing(new Span<int>(nums, 0, i + 1));
            var ldsLength = Decreasing(new Span<int>(nums, i, n - i));

            if (lisLength > 1 && ldsLength > 1)
            {
                ans = Math.Max(ans, lisLength + ldsLength - 1);
            }
        }
        return n - ans;
    }
    private static int Increasing(Span<int> nums)
    {
        return Longest(nums, Comparer<int>.Default);
    }
    private static int Decreasing(Span<int> nums)
    {
        return Longest(nums, Comparer<int>.Create((x, y) => y.CompareTo(x)));
    }
    private static int Longest(Span<int> nums, IComparer<int> comparer)
    {
        var n = nums.Length;
        List<int> res = new();
        res.Add(nums[0]);
        for (int i = 1; i < n; i++)
        {
            if (comparer.Compare(nums[i], res[res.Count - 1]) > 0)
            {
                res.Add(nums[i]);
            }
            else
            {
                int pos = res.BinarySearch(nums[i], comparer);
                if (pos < 0)
                {
                    pos = ~pos;
                }
                res[pos] = nums[i];
            }
        }
        return res.Count;
    }
}
