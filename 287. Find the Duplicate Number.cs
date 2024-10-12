public class Solution {
    public int FindDuplicate(int[] nums)
    {
        int fast = 0;
        int slow = 0;

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

        slow = 0;
        do
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        while(slow != fast);

        return slow;
    }
}
