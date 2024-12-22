public class Solution {
    public bool IsPalindrome(string s)
    {
        string convertedString = new string(s.ToLower().Where(c => Char.IsLetterOrDigit(c)).ToArray());
        return convertedString.SequenceEqual(convertedString.Reverse());
    }
}
