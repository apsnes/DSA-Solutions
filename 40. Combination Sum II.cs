public class Solution
{
    private List<IList<int>> res = new();

    public List<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        FindSum(0, 0, new List<int>(), target, candidates);
        return res;
    }

    private void FindSum(int currIndex, int currSum, List<int> currList, int target, int[] nums)
    {
        if (currSum > target) return;
        if (currSum == target)
        {
            res.Add(currList.ToList());
            return;
        }
        if (currIndex >= nums.Length) return;

        var currNum = nums[currIndex];
        currList.Add(currNum);
        currSum += currNum;
        FindSum(currIndex + 1, currSum, currList, target, nums);
        currList.RemoveAt(currList.Count - 1);
        currSum -= currNum;

        for (int i = currIndex; i < nums.Length; i++)
        {
            if (i == nums.Length - 1 && nums[i] == currNum) return;
            if (i < nums.Length - 1 && nums[i + 1] != currNum)
            {
                currIndex = i;
                break;
            }
        }

        FindSum(currIndex + 1, currSum, currList, target, nums);
    }
}
