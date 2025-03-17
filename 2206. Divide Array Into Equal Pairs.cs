public class Solution
{
    public bool DivideArray(int[] nums)
    {
        Dictionary<int, int> counts = new();
        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts[num] = 0;
            counts[num]++;
        }
        foreach (var entry in counts)
        {
            if (entry.Value % 2 == 1) return false;
        }
        return true;
    }
}
