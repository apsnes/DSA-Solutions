public class Solution {
    public bool IsHappy(int n)
    {       
        HashSet<int> seen = new();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = SumOfSquares(n);
        }

        return n == 1;
    }

    public int SumOfSquares(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}
