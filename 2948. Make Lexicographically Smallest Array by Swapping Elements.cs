public class Solution
{
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        int n = nums.Length;
        //Create a copy of the input array and sort it
        int[] sortedArray = nums.OrderBy(n => n).ToArray();
        //List of queues to store each grouping of numbers
        List<Queue<int>> queueList = new();
        //Dictionary to map each number to the index of its group in queueList and its index in the input
        Dictionary<int, int> numsGroupMap = new();

        //Store the previously seen value
        int prev = sortedArray[0];
        Queue<int> currentQueue = new();
        //Enqueue starter number
        currentQueue.Enqueue(prev);
        numsGroupMap.Add(prev, 0);

        for (int i = 1; i < n; i++)
        {
            //If difference is less than limit, add it to the current grouping
            if (Math.Abs(sortedArray[i] - prev) <= limit)
            {
                currentQueue.Enqueue(sortedArray[i]);
            }
            //if difference greater than limit, add the queue with previous numbers to the list and create a new
            //queue to add the current number to. This will make it the first number in the next grouping of numbers
            else
            {
                queueList.Add(currentQueue);
                currentQueue = new();
                currentQueue.Enqueue(sortedArray[i]);
            }
            //Map current number to its queue index
            if (!numsGroupMap.ContainsKey(sortedArray[i])) numsGroupMap.Add(sortedArray[i], queueList.Count);
            //Reassign prev to the current number
            prev = sortedArray[i];
        }
        //Add the final queue that was seen, as this would not happen upon exiting the loop for the last time
        queueList.Add(currentQueue);

        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            //Fill results array with smallest value from each group first
            int groupIndex = numsGroupMap[nums[i]];
            res[i] = queueList[groupIndex].Dequeue();
        }
        return res;
    }
}
