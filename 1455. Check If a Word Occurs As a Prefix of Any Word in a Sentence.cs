public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        string[] parts = sentence.Split(' ');
        int ans = -1;
        int wordLength = searchWord.Length;
        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i].Length >= wordLength && parts[i].Substring(0, wordLength).Contains(searchWord))
            {
                ans = i + 1;
                break;
            }
        }
        return ans;
    }
}
