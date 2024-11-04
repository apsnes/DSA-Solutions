public class Solution {
    public string CompressedString(string word)
    {
        StringBuilder sb = new();
        int n = word.Length;
        int start = 0;
        while (start < n)
        {
            char curr = word[start];
            int count = 0;
            int end = start;
            while (end < n && word[end] == curr && count < 9)
            {
                count++;
                end++;
            }
            sb.Append(count + curr.ToString());
            start = end;
        }
        return sb.ToString();
    }
}
