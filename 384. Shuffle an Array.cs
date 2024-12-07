public class Solution
{
    int[] originalArray;

    public Solution(int[] nums)
    {
        originalArray = nums;
    }
    
    public int[] Reset()
    {
        return originalArray;
    }
    
    public int[] Shuffle()
    {
        int[] shuffledArray = new int[originalArray.Length];
        HashSet<int> addedIndexes = new();
        Random random = new();
        for (int i = 0; i < originalArray.Length; i++)
        {
            int randomIndex = random.Next(0, originalArray.Length);
            while(addedIndexes.Contains(randomIndex))
            {
                randomIndex = random.Next(0, originalArray.Length);
            }
            addedIndexes.Add(randomIndex);
            shuffledArray[i] = originalArray[randomIndex];
        }
        return shuffledArray;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
