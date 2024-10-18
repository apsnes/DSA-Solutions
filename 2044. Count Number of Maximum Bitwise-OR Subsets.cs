public class Solution {
    public int CountMaxOrSubsets(int[] nums)
    {
        int max = 0;
        foreach (int num in nums)
        {
            max |= num;
        }
        int count = 0;
        void Backtrack(int index, int curr)
        {
            if (index == nums.Length)
            {
                if (curr == max)
                {
                    count++;
                }
                return;
            }
            Backtrack(index + 1, curr | nums[index]);
            Backtrack(index + 1, curr);
        }
        Backtrack(0, 0);
        return count;
    }
}
