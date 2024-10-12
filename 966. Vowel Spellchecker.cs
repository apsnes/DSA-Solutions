public class Solution {
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        HashSet<string> correctWords = new HashSet<string>(wordlist);
        Dictionary<string, string> caseMap = new();
        Dictionary<string, string> vowelMap = new();  

        for (int i = wordlist.Length - 1; i >= 0; i--)
        {
            string lowerCase = wordlist[i].ToLower();
            caseMap[lowerCase] = wordlist[i];
            string maskedString = MaskVowels(lowerCase);
            vowelMap[maskedString] = wordlist[i];
        }

        string[] ans = new string[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            string word = queries[i];
            string lowerWord = word.ToLower();
            string masked = MaskVowels(lowerWord);
            if (correctWords.Contains(word))
            {
                ans[i] = word;
            }
            else if (caseMap.ContainsKey(lowerWord))
            {
                ans[i] = caseMap[lowerWord];
            }
            else if (vowelMap.ContainsKey(masked))
            {
                ans[i] = vowelMap[masked];                
            }
            else
            {
                ans[i] = "";
            }
        }
        return ans;
    }

    private string MaskVowels(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                sb.Append('*');
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
