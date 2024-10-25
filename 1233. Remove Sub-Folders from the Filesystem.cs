public class Solution {
    public IList<string> RemoveSubfolders(string[] folder)
    {
        var sortedFolder = folder.OrderBy(a => a);
        IList<string> ans = new List<string>();
        string prefix = sortedFolder.ElementAt(0);
        foreach (string s in sortedFolder)
        {
            if (!s.StartsWith(prefix + "/"))
            {
                ans.Add(s);
                prefix = s;
            }
        }
        return ans;
    }
}
