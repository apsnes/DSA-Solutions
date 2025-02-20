public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        int n = nums.Length;
        HashSet<string> results = new();
        HashSet<string> seenVals = new();
        foreach(string num in nums)
        {
            seenVals.Add(num);
        }
        GenerateStrings(seenVals, "", n, results);
        return results.First();
    }
    private void GenerateStrings(HashSet<string> seenVals, string curr, int n, HashSet<string> results)
    {
        if (curr.Length == n)
        {
            if (!seenVals.Contains(curr))
            {
                results.Add(curr);
            }
            return;
        }
        GenerateStrings(seenVals, curr + "0", n, results);
        GenerateStrings(seenVals, curr + "1", n, results);
    }
}
