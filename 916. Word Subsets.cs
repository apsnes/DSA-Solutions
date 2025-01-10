public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        //Intuition - to check if a word in words1 is a match for all words in words2, we can simulate a check against all words at once by
        //checking the char count of word1 against the max count of that char from all words in words2
        List<string> ans = new();
        int[] charCounts = new int[26];
        foreach (string s in words2)
        {
            int[] currCounts = new int[26];
            foreach (char c in s)
            {
                //count all chars in word
                int i = c - 'a';
                currCounts[i]++;
                charCounts[i] = Math.Max(charCounts[i], currCounts[i]);
            }
        }
        //Check through wordsA to see which words match words2's count array
        foreach (string s in words1)
        {
            int[] currWordCounts = new int[26];
            foreach (char c in s)
            {
                currWordCounts[c - 'a']++;
            }
            bool isValidString = true;
            for (int i = 0; i < currWordCounts.Length; i++)
            {
                if (charCounts[i] > currWordCounts[i])
                {
                    isValidString = false;
                    break;
                }
            }
            if (isValidString) ans.Add(s);
        }
        return ans;
    }
}
