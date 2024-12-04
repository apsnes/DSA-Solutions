public class Solution {
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int s2Index = 0;
        int s2Length = str2.Length;

        foreach(char c in str1)
        {
            if (s2Index < s2Length && (str2[s2Index] - c + 26) % 26 <= 1)
            {
                s2Index++;
            }
        }
        return s2Index == s2Length;
    }
}
