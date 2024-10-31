public class Solution {
    public void ReverseString(char[] s)
    {
        for (int i = s.Length - 1, j = 0; i > j; i--, j++)
        {
            char temp = s[j];
            s[j] = s[i];
            s[i] = temp;
        }
    }
}
