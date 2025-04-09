public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        HashSet<int> set = new();
        foreach (int num in nums)
        {
            if (num < k) return -1;
            else if (num > k) set.Add(num);
        }
        return set.Count;
    }
}
