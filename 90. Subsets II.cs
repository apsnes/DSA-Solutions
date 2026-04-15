public class Solution
{
    private List<IList<int>> _subsets = new();
    private HashSet<string> _seen = new();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var currSubset = new List<int>();
        BuildSubsets(currSubset, 0, nums);
        return _subsets;
    }

    private void BuildSubsets(List<int> currSubset, int index, int[] nums)
    {
        if (index == nums.Length)
        {
            var keySet = new List<int>(currSubset);
            keySet.Sort();
            var key = string.Join(',', keySet);
            if (!_seen.Contains(key))
            {
                _subsets.Add(keySet);
                _seen.Add(key);
            }
            return;
        }
        currSubset.Add(nums[index]);
        BuildSubsets(currSubset, index + 1, nums);
        currSubset.RemoveAt(currSubset.Count - 1);
        BuildSubsets(currSubset, index + 1, nums);
    }
}
