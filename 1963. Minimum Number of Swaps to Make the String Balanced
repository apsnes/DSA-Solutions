public class Solution {
    public int MinSwaps(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        int balance = 0;
        int n = s.Length;
        char[] chars = s.ToCharArray();
        int j = n-1;
        int swapped = 0;

        for (int i = 0; i < n; i++)
        {
            if (chars[i] == '[')
            {
                balance++;
            }
            else
            {
                balance--;
            }
            if (balance < 0)
            {
                while (chars[j] != '[' && j > i)
                {
                    j--;
                }
                swapped ++;
                balance += 2;
            }
        }
        return swapped;
    }
}
