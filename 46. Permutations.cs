public class Solution
{
    private List<IList<int>> res = new();
    private HashSet<int> seen = new();

    public IList<IList<int>> Permute(int[] nums)
    {
        Backtrack(nums, new List<int>(), new HashSet<int>());
        return res;
    }

    private void Backtrack(int[] nums, List<int> currList, HashSet<int> seen)
    {
        if (currList.Count == nums.Length)
        {
            res.Add(new List<int>(currList));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (!seen.Contains(nums[i]))
            {
                seen.Add(nums[i]);
                currList.Add(nums[i]);
                Backtrack(nums, currList, seen);
                seen.Remove(nums[i]);
                currList.RemoveAt(currList.Count - 1);
            }
        }
    }
}
