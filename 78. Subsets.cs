class Solution
{
    private List<List<int>> _subsets = new();
    private int[] _nums;

	public List<List<int>> Subsets(int[] nums)
	{
        _nums = nums;

        var currSet = new List<int>();
        BuildSubset(currSet, 0);			

		return _subsets.ToList();
	}

    private void BuildSubset(List<int> currSubset, int currIndex)
    {
        if (currIndex == _nums.Length)
        {
            var copy = new List<int>(currSubset);
            _subsets.Add(copy);
            return;
        }
        
        currSubset.Add(_nums[currIndex]);
        BuildSubset(currSubset, currIndex + 1);
        currSubset.Remove(_nums[currIndex]);
        BuildSubset(currSubset, currIndex + 1);
    }
}
