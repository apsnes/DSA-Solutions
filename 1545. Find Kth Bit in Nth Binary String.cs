public class Solution {
    public char FindKthBit(int n, int k)
    {
        string s = "0";
        while (n > 0)
        {
            s = $"{s}1{Invert(s)}";
            n--;
        }
        return s[k-1];
    }

    private string Invert(string s)
    {
        char[] chars = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (chars[i] == '0')
            {
                chars[i] = '1';
            }
            else
            {
                chars[i] = '0';
            }
        }
        Array.Reverse(chars);
        return new string(chars);
    }
}
