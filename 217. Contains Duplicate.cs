public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new();
        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
