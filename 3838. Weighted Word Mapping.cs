public class Solution
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        var sb = new StringBuilder();

        foreach (var word in words)
        {
            var currWeight = 0;
            foreach (var c in word)
            {
                currWeight += weights[c - 'a'];
            }
            var modWeight = currWeight % 26;
            var currChar = 'z' - modWeight;
            sb.Append((char)currChar);
        }

        return sb.ToString();
    }
}
