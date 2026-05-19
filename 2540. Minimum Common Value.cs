public class Solution 
    {
    public int GetCommon(int[] nums1, int[] nums2) 
    {
        var set = new HashSet<int>(nums2);
        foreach (var num in nums1)
        {
            if (set.Contains(num)) return num;
        }
        return -1;
    }
}
