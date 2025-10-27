public class Solution {
    public int NumberOfBeams(string[] bank)
    {
        int prev = 0, res = 0;
        for (int i = 0; i < bank.Length; i++)
        {
            var rowCount = bank[i].Count(x => x == '1');
            if (rowCount > 0)
            {
                res += prev * rowCount;
                prev = rowCount;
            }
        }
        return res;
    }
}
