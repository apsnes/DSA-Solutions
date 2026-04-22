public class Solution
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary)
    {
        var res = new List<string>();
        foreach (var q in queries)
        {
            foreach (var w in dictionary)
            {
                var count = 0;
                for (int i = 0; i < q.Length; i++)
                {
                    if (q[i] != w[i]) count++;
                }
                if (count < 3)
                {
                    res.Add(q);
                    break;
                }
            }
        }
        return res;
    }
}
