public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nums2Dict = new();
        foreach (int num in nums2)
        {
            if (!nums2Dict.ContainsKey(num)) nums2Dict[num] = 0;
            nums2Dict[num]++;
        }
        List<int> result = new();
        foreach (int num in nums1)
        {
            if (nums2Dict.ContainsKey(num) && nums2Dict[num] > 0)
            {
                nums2Dict[num]--;
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}
