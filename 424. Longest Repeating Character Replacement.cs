public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var n = s.Length;
        if (n == 1) return 1;
        var res = 1;

        var charDict = new Dictionary<char, int>();
        var maxFreqChar = 0;

        var left = 0;
        var right = 1;
        charDict[s[left]] = 1;

        while (right < n)
        {
            var currRight = s[right];
            if (!charDict.ContainsKey(currRight)) charDict[currRight] = 0;
            charDict[currRight]++;

            maxFreqChar = Math.Max(maxFreqChar, charDict[currRight]);

            while ((right - left + 1) - maxFreqChar > k)
            {
                var currLeft = s[left];
                charDict[currLeft]--;
                left++;
            }

            res = Math.Max(res, right - left + 1);
            right++;
        }
        return res;
    }
}
