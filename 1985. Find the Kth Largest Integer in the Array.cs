public class Solution
{
    public string KthLargestNumber(string[] nums, int k)
    {
        var pq = new PriorityQueue<string, string>(new CustomComparer());

        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
            if (pq.Count > k) pq.Dequeue();
        }
        return pq.Dequeue();
    }

    class CustomComparer : IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            return s1.Length == s2.Length ? s1.CompareTo(s2) : s1.Length - s2.Length;
        }
    }
}
