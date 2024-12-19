//BFS algorithm solution
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict)
    {
        //Convert wordDict to a HashSet to retrieve words in O(1) time
        HashSet<string> words = new(wordDict);
        //Keep an array of bools to prevent visiting same node twice
        bool[] seen = new bool[s.Length + 1];
        Queue<int> indexQueue = new();
        //Enqueue first index of the string
        indexQueue.Enqueue(0);

        while (indexQueue.Count > 0)
        {
            //Retrieve current index from the queue
            int start = indexQueue.Dequeue();
            //If we've reached the end of the string, return true
            if (start == s.Length) return true;
            for (int end = start + 1; end <= s.Length; end++)
            {
                //If we havent seen this index before
                if (seen[end] == false)
                {
                    string currentSubstring = s.Substring(start, end - start);
                    if (words.Contains(currentSubstring))
                    {
                        indexQueue.Enqueue(end);
                        seen[end] = true;
                    }
                }
            }
        }
        //If we never reach the end of the string
        return false;
    }
}
