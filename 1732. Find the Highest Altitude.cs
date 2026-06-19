public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var altitude = 0;
        var max = 0;
        foreach (var i in gain)
        {
            altitude += i;
            max = Math.Max(max, altitude);
        }
        return max;
    }
}
