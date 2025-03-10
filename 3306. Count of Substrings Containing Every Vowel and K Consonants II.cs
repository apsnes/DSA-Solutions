public class Solution
{
    public long CountOfSubstrings(string word, int k)
    {
        return countSubStrings(word, k) - countSubStrings(word, k + 1);
    }
    private long countSubStrings(string word, int k)
    {
        long total = 0;
        int left = 0, right = 0;
        Dictionary<char, int> vowels = new();
        int consCount = 0;
        while (right < word.Length)
        {
            char curr = word[right];

            if (isVowel(curr))
            {
                if (!vowels.ContainsKey(curr)) vowels[curr] = 0;
                vowels[curr]++;
            }
            else
            {
                consCount++;
            }
            while(vowels.Count == 5 && consCount >= k)
            {
                total += word.Length - right;
                char leftChar = word[left];
                if (isVowel(leftChar))
                {
                    vowels[leftChar]--;
                    if (vowels[leftChar] == 0) vowels.Remove(leftChar);
                }
                else
                {
                    consCount--;
                }
                left++;
            }
            right++;
        }
        return total;
    }
    private bool isVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
