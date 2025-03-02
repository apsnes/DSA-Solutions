public class Solution
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        SortedDictionary<int, int> sums = new();
        foreach (var arr in nums1)
        {
            if (!sums.ContainsKey(arr[0])) sums[arr[0]] = 0;
            sums[arr[0]] += arr[1];
        }
        foreach (var arr in nums2)
        {
            if (!sums.ContainsKey(arr[0])) sums[arr[0]] = 0;
            sums[arr[0]] += arr[1];
        }
        int[][] ans = new int[sums.Count][];
        int index = 0;
        foreach (var entry in sums)
        {
            ans[index] = new int[2];
            ans[index][0] = entry.Key;
            ans[index][1] = entry.Value;
            index++;
        }
        return ans;
    }
}
