public class Solution
{
    public int MinElement(int[] nums)
    {
        var min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            var curr = nums[i].ToString();
            var currSum = 0;
            foreach (var c in curr)
            {
                var currVal = c - '0';
                currSum += currVal;
            }
            min = Math.Min(min, currSum);
        }

        return min;
    }
}
