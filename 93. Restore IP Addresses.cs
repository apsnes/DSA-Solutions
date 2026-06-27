public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> res = new();
        if (s.Length < 4 || s.Length > 12) return res;
        Dfs(0, "", s, res, 0);
        return res;
    }

    private void Dfs(int index, string path, string s, List<string> res, int dotCount)
    {
        if (dotCount == 4 && index == s.Length)
        {
            res.Add(path.Substring(0, path.Length - 1)); 
            return;
        }

        if (dotCount > 3 || index >= s.Length) return;

        for (int len = 1; len <= 3; len++)
        {
            if (index + len > s.Length) break;
            string segmentStr = s.Substring(index, len);
            if (segmentStr.Length > 1 && segmentStr[0] == '0') break;
            int segmentVal = int.Parse(segmentStr);
            if (segmentVal <= 255)
                Dfs(index + len, path + segmentStr + ".", s, res, dotCount + 1);
        }
    }
}
