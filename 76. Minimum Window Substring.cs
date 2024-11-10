public class Solution {
    public string MinWindow(string s, string t)
    {
        //Handle edge cases
        if (s == t) return s;
        if (s.Length < t.Length) return "";
        //int to store current minimum length substring and one to store its indexes
        int min = Int32.MaxValue;
        (int, int) minIndexes = (0, s.Length);

        //int to store amount of needed characters currently possessed
        int possessedCount = 0;

        //Add required characters to needed dictionary
        Dictionary<char, int> neededCharacters = new();

        foreach (char c in t)
        {
            if (!neededCharacters.ContainsKey(c)) neededCharacters[c] = 0;
            neededCharacters[c]++;
        }

        //int to store count of dictionary matches needed for valid string
        int neededCount = neededCharacters.Count;

        //Add Dictionary to store currently possessed characters
        Dictionary<char, int> possessedCharacters = new();

        //iterate through string adding one extra character to our substring until we have all the characters needed (possessedCount == neededCount)
        //update the min length substring variable if required
        int left = 0;
        int right = 0;
        while (right < s.Length)
        {
            //if we found a valid substring
            if (neededCount == possessedCount)
            {
                if ((right - left + 1) < min)
                {
                    min = right - left + 1;
                    minIndexes = (left, right);
                }
                //begin removing characters from the left. Once possessedCount != neededCount, begin adding characters from
                //the right again until the substring is valid once more.
                if (possessedCharacters.ContainsKey(s[left]))
                {
                    possessedCharacters[s[left]]--;
                    if (possessedCharacters[s[left]] < neededCharacters[s[left]])
                    {
                        if (right < s.Length - 1) right++;
                        else break;
                        possessedCount--;
                    } 
                }
                left++;
            }
            else 
            {
                if (neededCharacters.ContainsKey(s[right]))
                {
                    if (!possessedCharacters.ContainsKey(s[right])) possessedCharacters[s[right]] = 0;
                    possessedCharacters[s[right]]++;
                    if (possessedCharacters[s[right]] == neededCharacters[s[right]])
                    {
                        possessedCount++;
                    }
                }
                if (possessedCount != neededCount)
                {
                    right++;
                }
            }
        }
        //if min was never updated, no valid substring was found
        if (min == Int32.MaxValue) return "";
        int length = minIndexes.Item2 - minIndexes.Item1 + 1;
        return s.Substring(minIndexes.Item1, length);
    }
}
