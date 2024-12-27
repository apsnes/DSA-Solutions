public class Solution {
    public int MaxScoreSightseeingPair(int[] values)
    {
        //Initialise a maxLeftScore variable to keep track of the max score to the left of each index
        int maxLeftScore = values[0];
        //Initialise a variable to keep track of the highest score we've seen throughout iterations of the algorithm
        int maxScore = 0;
        for (int i = 1; i < values.Length; i++)
        {
            //Calculate the current value of values[i] being used as both the left number (i) and the right number (j)
            int currRight = values[i] - i;
            int currLeft = values[i] + i;
            //Update maxScore if we have found a higher score
            maxScore = Math.Max(maxScore, maxLeftScore + currRight);
            //Update maxLeftScore if we have found a higher score
            maxLeftScore = Math.Max(maxLeftScore, currLeft);
        }
        return maxScore;
    }
}
