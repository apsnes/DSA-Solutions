public class Solution {
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < items.Length; i++)
        {
            if (!dict.ContainsKey(items[i][0])) dict[items[i][0]] = items[i][1];
            else dict[items[i][0]] = Math.Max(dict[items[i][0]], items[i][1]);
        }
        List<int> sortedPrices = new List<int>(dict.Keys);
        sortedPrices.Sort();
        for (int i = 1; i < sortedPrices.Count; i++)
        {
            dict[sortedPrices[i]] = Math.Max(dict[sortedPrices[i]], dict[sortedPrices[i - 1]]);
        }
        int[] ans = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            ans[i] = GetMax(sortedPrices, dict, queries[i]);
        }
        return ans;
    }

    private int GetMax(List<int> sortedPrices, Dictionary<int, int> dict, int queryPrice)
    {
        int left = 0;
        int right = sortedPrices.Count - 1;
        int maxBeauty = 0;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (sortedPrices[mid] <= queryPrice)
            {
                maxBeauty = dict[sortedPrices[mid]];
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return maxBeauty;     
    }
}
