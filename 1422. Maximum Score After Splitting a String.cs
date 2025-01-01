//Two passes - initial solution:
public class Solution
{
    public int MaxScore(string s)
    {
        //Calculate sum of array (number of ones)
        int sum = s.ToCharArray().Where(c => c == '1').Count();
        //Initialise var to keep track of the maxSum seen and the current zeroCount
        int maxSum = 0;
        int zeroCount = 0;
        //iterate from 0 to n-2, as a split cannot be made at the last index
        for (int i = 0; i < s.Length - 1; i++)
        {
            //Update the zero and one values for the current char
            if (s[i] == '0') zeroCount++;
            else sum--;
            //Check if current value is greatest seen so far
            maxSum = Math.Max(maxSum, zeroCount + sum);
        }
        return maxSum;
    }
}
