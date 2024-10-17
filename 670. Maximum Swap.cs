public class Solution {
    public int MaximumSwap(int num)
    {
        string asString = num.ToString();
        char[] chars = asString.ToCharArray();
        int maxIndex = -1;
        int firstSwap = -1;
        int secondSwap = -1;
        int n = asString.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (maxIndex == -1 || (chars[i] - '0') > (chars[maxIndex] - '0'))
            {
                maxIndex = i;
            }
            else if ((chars[i] - '0') < (chars[maxIndex] - '0'))
            {
                firstSwap = i;
                secondSwap = maxIndex;
            }
        }
        if (firstSwap != -1 && secondSwap != -1)
        {
            char temp = chars[firstSwap];
            chars[firstSwap] = chars[secondSwap];
            chars[secondSwap] = temp;
        }
        return Int32.Parse(new string(chars));
    }
}
