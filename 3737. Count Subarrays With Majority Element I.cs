public class Solution
{
    public int CountMajoritySubarrays(int[] nums, int target)
    {
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var count = 0;
            for (int j = i; j < nums.Length; j++)
            {
                count += nums[j] == target ? 1 : -1;
                if (count > 0) res++;
            }
        }

        return res;
    }
}
