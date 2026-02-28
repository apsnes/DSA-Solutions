public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();
        var res = right;

        while (left <= right)
        {
            var curr = (left + right) / 2;

            if (CanEatBananas(piles, h, curr))
            {
                right = curr - 1;
                res = curr;
            }
            else
            {
                left = curr + 1;
            }
        }
        return res;
    }

    private bool CanEatBananas(int[] piles, int h, int k)
    {
        long timeTaken = 0;
        foreach (var banana in piles)
        {
            var time = (banana * 1.0) / k;
            timeTaken += Convert.ToInt64(Math.Ceiling(time));
        }
        return timeTaken <= h;
    }
}
