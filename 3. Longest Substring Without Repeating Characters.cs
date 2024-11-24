//Sub optimal solution
//--------------------
public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;
        int left = 0;
        int right = 1;
        int maxLength = 0;
        while (right < s.Length)
        {
            //if substring is valid, increment right pointer and check to see if currentLength > maxLength
            string currentSubstring = s.Substring(left, right - left + 1);
            if (IsValidSubstring(currentSubstring))
            {
                maxLength = Math.Max(maxLength, currentSubstring.Length);
                right++;
            }
            //if invalid, incremement left pointer and check next substring
            else
            {
                left++;
            }
        }
        return maxLength;
    }
    public bool IsValidSubstring(string s)
    {
        Dictionary<char, int> dict = new();
        foreach (char c in s)
        {
            dict[c] = dict.GetValueOrDefault(c) + 1;
        }
        foreach (var val in dict.Values)
        {
            if (val > 1) return false;
        }
        return true;
    }
}

//Efficient solution
//------------------
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int maxLength = 0;
        HashSet<char> set = new();
        int left = 0;
      
        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }     
        return maxLength;
    }
}
