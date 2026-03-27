public class Solution
{
    public List<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i - 1] == nums[i]) continue;

            var left = i + 1;
            var right = nums.Length - 1;
            while(left < right)
            {
                var currSum = nums[i] + nums[left] + nums[right];
                if (currSum == 0)
                {
                    res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                }
                else if (currSum > 0) right--;
                else left++;
            }
        }
        return res;
    }
}
