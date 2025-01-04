public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        //Store each anagram as a List<string> in a dictionary
        Dictionary<string, List<string>> strings = new();
        foreach (string s in strs)
        {
            //Sort the current string to use as a key for the dictionary and add the current string to the list of that entry
            string sortedString = new string(s.OrderBy(c => c).ToArray());
            if (!strings.ContainsKey(sortedString)) strings[sortedString] = new List<string>();
            strings[sortedString].Add(s);
        }
        List<IList<string>> ans = new();
        foreach (var entry in strings)
        {
            //Add each anagram list to the answer list
            ans.Add(entry.Value);
        }
        return ans;
    }
}
