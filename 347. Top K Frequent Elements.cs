//Optimised Bucket Sort solution
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        //Create a dictionary to store counts of numbers in nums
        Dictionary<int, int> counts = new();
        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts[num] = 0;
            counts[num]++;
        }
        //Create a List<int> array of size nums.Length + 1. The indexes of this array are to be the counts of the numbers that are stored
        //in that index.
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new();
        }
        //For each kvp entry in the dictionary, the entry.Value is the number of times that the entry.Key appears in nums. Therefore, we
        //need to add the entry.Key to the index of entry.Value in our buckets array
        foreach (var entry in counts)
        {
            buckets[entry.Value].Add(entry.Key);
        }
        //Create an array for our answer
        int[] ans = new int[k];
        //Create a variable to keep track of the current index of our answer array that we need to add to
        int index = 0;
        //As the most frequent values are at the end of our array, we iterate backwards so long as we're within the boundary and
        //we haven't yet added all k values to our answer array
        for (int i = buckets.Length - 1; i >= 0 && index < k; i--)
        {
            //Iterate over the list at the current frequency index and add the number there to our answer array. If we reach k values added,
            //return our answer here to prevent attempting to add a value to an out of bounds index
            for (int j = 0; j < buckets[i].Count; j++)
            {
                ans[index] = buckets[i][j];
                index++;
                if (index == k) return ans;
            }
        }
        return ans;
    }
}

//Priority Queue solution
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        //Dictionary to store counts of each number
        Dictionary<int, int> counts = new();
        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts[num] = 0;
            counts[num]++;
        }
        //Create priority queue and enqueue all numbers, prioritised by their counts with the highest count first
        PriorityQueue<int, int> pq = new();
        foreach (var entry in counts)
        {
            pq.Enqueue(entry.Key, 0 - entry.Value);
        }
        //Initiate our answer array
        int[] ans = new int[k];
        for (int i = 0; i < k; i++)
        {
            //Dequeue k total numbers and add them to our answer array
            ans[i] = pq.Dequeue();
        }
        return ans;
    }
}
