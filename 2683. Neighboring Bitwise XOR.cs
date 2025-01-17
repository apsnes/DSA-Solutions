public class Solution
{
    public bool DoesValidArrayExist(int[] derived)
    {
        int first = 0;
        int last = 0;

        foreach (int num in derived)
        {
            if (num == 1) last = ~last;
        }
        return first == last;
    }
}
