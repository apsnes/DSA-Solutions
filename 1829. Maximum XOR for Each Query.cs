public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        int mask = (1 << maximumBit) - 1;
        int[] result = new int[nums.Length];
        int cumulativeXor = 0;
        foreach (int num in nums) cumulativeXor ^= num;

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = cumulativeXor ^ mask;
            cumulativeXor ^= nums[nums.Length - 1 - i];
        }
        return result;
    }
}
