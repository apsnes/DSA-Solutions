public class Solution {
    public bool IsCircularSentence(string sentence)
    {
        int n = sentence.Length;
        if (sentence[0] != sentence[n - 1])
        {
            return false;
        }
        for (int i = 0; i < n; i++)
        {
            if (sentence[i] == ' ')
            {
                if (sentence[i - 1] != sentence[i + 1])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
