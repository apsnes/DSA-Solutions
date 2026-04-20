public class Solution
{
    public int MaxDistance(int[] colors)
    {
        var max = 1;
        for (int i = 0; i < colors.Length - 1; i++)
        {
            if (colors[i] != colors[^1]) max = Math.Max(max, colors.Length - i - 1);
        }

        for (int i = colors.Length - 1; i > 0; i--)
        {
            if (colors[i] != colors[0]) max = Math.Max(max, i);
        }

        return max;
    }
}
