public class Solution
{
    public int MaximumSum(int[] nums)
    {
        Dictionary<int, List<int>> digitSums = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = CountDigitSum(nums[i]);
            if (!digitSums.ContainsKey(sum)) digitSums[sum] = new();
            digitSums[sum].Add(nums[i]);
        }
        int maxResult = -1;
        foreach (var list in digitSums.Values)
        {
            if (list.Count < 2) continue;
            list.Sort();
            int maxInList = list[list.Count - 1] + list[list.Count - 2];
            maxResult = Math.Max(maxInList, maxResult);
        }
        return maxResult;
    }

    private int CountDigitSum(int num)
    {
        int total = 0;
        string numAsString = num.ToString();
        foreach (char c in numAsString)
        {
            total += c - '0';
        }
        return total;
    }
}
