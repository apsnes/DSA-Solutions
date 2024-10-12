public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }
        
        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {   
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;

        for (int i = 0; i < 26; i++)
        {
            if (s1Count[i] == s2Count[i])
            {
                matches++;
            }
        }

        int left = 0;
        for (int right = s1.Length; right < s2.Length; right++)
        {
            if (matches == 26)
            {
                return true;
            }

            int i = (int)s2[right] - 'a';

            s2Count[i]++;

            if (s1Count[i] == s2Count[i])
            {
                matches++;
            }
            else if (s1Count[i] + 1 == s2Count[i])
            {
                matches--;
            }

            i = s2[left] - (int)'a';

            s2Count[i]--;

            if (s1Count[i] == s2Count[i])
            {
                matches++;
            }
            else if (s1Count[i] -1 == s2Count[i])
            {
                matches--;
            }
            left++;
        }
        return matches == 26;
    }
}
