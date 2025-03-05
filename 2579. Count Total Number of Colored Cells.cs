public class Solution
{
    public long ColoredCells(int n)
    {
        return 1 + (long) n * (n - 1) * 2;
    }
}
