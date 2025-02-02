public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] ans = new int[n];
        List<int> indicies = new();
        for (int i = 0; i < n; i++)
        {
            if (s[i] == c) indicies.Add(i);
        }
        for (int i = 0; i < n; i++)
        {
            if (s[i] == c) ans[i] = 0;
            int distance = int.MaxValue;
            foreach (int index in indicies)
            {
                distance = Math.Min(distance, Math.Abs(index - i));
            }
            ans[i] = distance;
        }
        return ans;
    }
}
