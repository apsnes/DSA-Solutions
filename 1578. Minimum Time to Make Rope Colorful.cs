public class Solution {
    public int MinCost(string colors, int[] neededTime)
    {
        var n = colors.Length;
        int left = 0, right = 0, total = 0;
        while (right < n)
        {
            int currentTotal = 0, currentMax = 0;

            while (right < n && colors[left] == colors[right])
            {
                currentTotal += neededTime[right];
                currentMax = Math.Max(currentMax, neededTime[right]);
                right++;
            }
            total += currentTotal - currentMax;
            left = right;
        }
        return total;
    }
}
