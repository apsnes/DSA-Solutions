public class Solution {
    public int LargestCombination(int[] candidates)
    {
        int[] freq = new int[24];
        foreach (int num in candidates)
        {
            for (int bit = 0; bit < 24; bit++)
            {
                if ((num &(1 << bit)) != 0)
                {
                    freq[bit]++;
                }
            }           
        }
        int maxCount = 0;
        foreach (int count in freq)
        {
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }
}
