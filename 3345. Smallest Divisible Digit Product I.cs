public class Solution {
    public int SmallestNumber(int n, int t)
    {
        for (int i = n; i < n + 10; i++)
        {
            int product = getDigits(i);
            if (product % t == 0) return i;
        }
        return 0;
    }

    private int getDigits(int n)
    {
        string asString = n.ToString();
        int product = asString[0] - '0';
        for (int i = 1; i < asString.Length; i++)
        {
            product *= (asString[i] - '0');
        }
        return product;
    }
}
