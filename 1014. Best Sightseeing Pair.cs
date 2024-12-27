public class Solution
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        //Initialise a variable to keep track of the best left score we've seen so far. We don't care about previous
        //best scores. If we did, we'd use a dp int[]
        int maxLeftScore = values[0];
        //Initialise a variable to keep track of the highest score we've seen throughout iterations of the algorithm
        int maxScore = 0;
        //Iterate from 1 to n to check all remaining indicies' scores
        for (int i = 1; i < values.Length; i++)
        {
            //Intuition tells us that each value in the array can be used as either the left side of the equation 
            //(values[i] + i) or the right side of the equation  (values[i] - i), so we calculate both:
            int currRight = values[i] - i;
            int currLeft = values[i] + i;
            //We can use the previously seen maxLeftScore to calculate the current score using currRight:
            //MaxLeftScore + currRight
            //Under the hood, that looks like:
            //(values[i] + i) + (values[j] - j)
            //Which when rewritten is the same as the problem definition:
            //Values[i] + values[j] + i - j
            //So we update maxScore if the new score is higher:
            maxScore = Math.Max(maxScore, maxLeftScore + currRight);
            //We then update maxLeftScore if the current left score is higher:
            maxLeftScore = Math.Max(maxLeftScore, currLeft);
        }
        return maxScore;
    }
}
