// Dictionary Solution
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

// LINQ Solution
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var stringList = new List<StringObject>();

        for (int i = 0; i < strs.Length; i++)
        {
            stringList.Add(new StringObject() { Content = strs[i], OrderedContent = string.Concat(strs[i].OrderBy(c => c)), Index = i});
        }

        var groupByOrderedString = stringList.GroupBy(str => str.OrderedContent);
        var res = new List<IList<string>>();

        foreach (var group in groupByOrderedString)
        {
            res.Add(group.OrderBy(x => x.Index).Select(s => s.Content).ToList());
        }

        return res;
    }
}

public class StringObject
{
    public string Content { get; set; }
    public string OrderedContent { get; set; }
    public int Index { get; set; }
}
