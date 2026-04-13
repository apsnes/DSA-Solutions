public class Solution
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        var leftIndex = start;
        var rightIndex = start;
        while (true)
        {
            if (leftIndex >= 0 && nums[leftIndex] == target) return Math.Abs(leftIndex - start);
            if (rightIndex < nums.Length && nums[rightIndex] == target) return Math.Abs(rightIndex - start);
            leftIndex--;
            rightIndex++;
        }
        return -1;
    }
}
