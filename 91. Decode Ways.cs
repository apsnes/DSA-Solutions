public class Solution
{   
    public int NumDecodings(string s)
    {
        //Create dynamic programming array to cache previously computed values
        int[] dp = new int[s.Length + 1];
        //Fill with -1 so that we can see when a value has already been computed
        Array.Fill(dp, -1);
        //Set the final element (out of bounds of the string) to 1, which can be returned as a 'way of decoding' upon 
        //reaching the end
        dp[s.Length] = 1;
        return calculateWays(0, dp, s);
    }
    public int calculateWays(int index, int[] dp, string s)
    {
        //Base case - we've already computed this value, return it
        if (dp[index] != -1) return dp[index];
        //If the char at the current index is 0, this is an invalid number as we can only compute numbers in the range
        //1-26. Therefore we skip it.
        if (s[index] == '0') return 0;
        //Initialise a result variable which will store the number of possible ways to decode the string from the current
        //index to the end of the string
        int result = calculateWays(index + 1, dp, s);
        //If the current number is a 1, we can compute the digits at i + i+1 as a pair, e.g "11" as a possible way of
        //decoding. If the current number is a 2, we have to check that the number at i+1 is below 7, as we are only
        //able to compute numbers 20-26 in this scenario. If either of these statements is true, we can add this to our
        //current result of ways to decode.
        if (index + 1 < s.Length && (s[index] == '1' || s[index] == '2' && s[index + 1] < '7'))
        {
            result += calculateWays(index + 2, dp, s);
        }
        //Add the computed result to our dp array for faster future computing
        dp[index] = result;
        return result;
    }
}
