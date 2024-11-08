public class Solution {
    public IList<IList<int>> Subsets(int[] nums)
    {
        var results = new List<IList<int>>();
        var subset = new List<int>();
        Dfs(nums, 0, subset, results);
        return results;    
    }

    private void Dfs(int[] nums, int i, List<int> subset, List<IList<int>> results)
    {
        if (i >= nums.Length)
        {
            results.Add(new List<int>(subset));
            return;
        }
        subset.Add(nums[i]);
        Dfs(nums, i + 1, subset, results);
        subset.RemoveAt(subset.Count - 1);
        Dfs(nums, i + 1, subset, results);
    }
}
