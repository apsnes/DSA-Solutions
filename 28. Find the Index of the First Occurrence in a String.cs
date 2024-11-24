public class Solution {
    public int StrStr(string haystack, string needle)
    {
        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            string currentString = haystack.Substring(i, needle.Length);
            if (currentString == needle) return i;
        }
        return -1;
    }
}
