public class Solution {
    public string ClearStars(string s)
    {
        StringBuilder sb = new();
        PriorityQueue<int, int> pq = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                int curr = pq.Dequeue();
                if (curr >= 0)
                {
                    sb.Replace(s[curr], '*', curr, 1);
                }
            }
            else
            {
                pq.Enqueue(i, (int)(s[i]-'a') * 100000 - i);
            }
            sb.Append(s[i]);
        }
        sb.Replace("*", "");
        return sb.ToString();
    }
}
