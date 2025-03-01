public class Solution
{
    public int[] ApplyOperations(int[] nums)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1] && nums[i] != 0)
            {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
            if (nums[i] != 0)
            {
                if (i != index)
                {
                    int temp = nums[i];
                    nums[i] = nums[index];
                    nums[index] = temp;
                }
                index++;
            }
        }
        return nums;
    }
}
