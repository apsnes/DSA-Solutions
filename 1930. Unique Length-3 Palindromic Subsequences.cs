public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        int ans = 0;
        //Instantiate a dictionary to keep note of the min and max index of each char in the string
        Dictionary<char, int[]> charDict = new();
        //Populate the dictionary with one pass
        for (int i = 0; i < s.Length; i++)
        {
            //Set the max index at a default value of -1
            if (!charDict.ContainsKey(s[i])) charDict[s[i]] = new int[] { i, -1 };
            //The entry already exists, so we update the max index for this character 
            else charDict[s[i]][1] = i;
        }
        foreach (var entry in charDict)
        {
            //If the max index is still set to -1, we only found one of this character and no valid palindrome can be made, so we continue
            //(we could omit this line and the method will still work as the loop on line 28 would not run anyway, but for efficiency and readability
            //we continue here)
            if (entry.Value[1] == -1) continue;
            //create a hashset to store unique characters found in O(1) time
            HashSet<char> uniqueChars = new();
            //Iterate from the min char index + 1, to the max char index. As we know that these two characters are the same, we can place any
            //character we want in to the middle of the string and it will still be a valid palindrome of length 3. The only thing we need to
            //do is ensure that we dont count the exact same string twice, which our hashset handles for us. We do not need to actually build
            //the strings, simply counting how many unique strings that it is possible to make will suffice.
            for (int i = entry.Value[0] + 1; i < entry.Value[1]; i++)
            {
                uniqueChars.Add(s[i]);
            }
            //Add the count of the unique chars found to our answer varialbe and move on to the next entry in the dictionary
            ans += uniqueChars.Count;
        }
        return ans;
    }
}
