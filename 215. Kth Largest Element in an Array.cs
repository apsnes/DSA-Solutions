public class Solution {

    int newK = 0;

    public int FindKthLargest(int[] nums, int k)
    {   
        this.newK = nums.Length - k;
        return quickSelect(nums, 0, nums.Length - 1);
    }

    private int quickSelect(int[] nums, int l, int r)
    {
        int pivot = nums[r];
        int p = nums[l];
        for (int i = l; i < r; i++)
        {
            if (nums[i] <= pivot)
            {
                int temp = nums[i];
                nums[i] = nums[p];
                nums[p] = nums[i];
                p++;
            }
        }
        int newTemp = nums[p];
        nums[p] = pivot;
        nums[r] = newTemp;

        if (p > newK)
        {
           return quickSelect(nums, l, p - 1);
        }
        else if (p < newK)
        {
            return quickSelect(nums, p + 1, r);
        }
        else
        {
            return nums[p];
        }
    }
}
