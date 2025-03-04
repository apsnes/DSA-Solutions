public class Solution
{
    public bool CheckPowersOfThree(int n)
    {
        int power = 0;
        while (Math.Pow(3, power + 1) <= n)
        {
            power++;
        }
        while (n > 0)
        {
            if (n >= (Math.Pow(3, power)))
            {
                n -= (int)Math.Pow(3, power);
            }
            if (n >= Math.Pow(3, power))
            {
                return false;
            }
            power--;
        }
        return true;
    }
}
