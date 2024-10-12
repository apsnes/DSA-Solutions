public class Solution {
    public string FrequencySort(string s)
    {
        Dictionary<char,int> dict = new();
        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }
        PriorityQueue<char, int> pq = new();
        foreach(KeyValuePair<char, int> entry in dict)
        {
            pq.Enqueue(entry.Key, 0 - entry.Value); 
        }
        StringBuilder sb = new();
        while (pq.Count > 0)
        {
            char currChar = pq.Dequeue();
            for (int j = 0; j < dict[currChar]; j++)
            {
                sb.Append(currChar);
            }
        }
        return sb.ToString();
    }
}
