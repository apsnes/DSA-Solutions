public class Solution {

    public bool IsValid(int[] bags, int maxBalls, int maxOperations)
    {
        int ops = 0;
        foreach (int n in bags) {
            ops += (n + maxBalls - 1) / maxBalls - 1;
            if (ops > maxOperations) return false;
        }
        return true;
    }
    public int MinimumSize(int[] bags, int maxOperations)
    {
        int left = 0, right = bags.Max();
        int result = right;
        while (left < right)
        {
            int middle = left + (right - left) / 2;
            if (IsValid (bags, middle, maxOperations))
            {
                right = middle;
                result = right;
            }
            else
            {
                left = middle + 1;
            }
        }
        return result;
    }
}
