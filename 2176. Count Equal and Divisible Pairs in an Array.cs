public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        int res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((i * j) % k == 0 && nums[i] == nums[j]) res++;
            }
        }
        return res;
    }
}
