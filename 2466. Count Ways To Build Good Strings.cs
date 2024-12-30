public class Solution
{
    //Var to keep hold of the mod value
    double mod = Math.Pow(10, 9) + 7;
    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        //DP Dictionary
        Dictionary<int, int> memo = new();
        //Run DFS algorithm starting at index 0
        return dfs(0, high, low, zero, one, memo);
    }
    public int dfs(int length, int high, int low, int zero, int one, Dictionary<int, int> memo)
    {
        //Base case - length is larger than largest permitted string length
        if (length > high) return 0;
        //We've already computed the required value, return it
        if (memo.ContainsKey(length)) return memo[length];
        //Initialise result variable to 0
        int result = 0;
        //If we have come across a new good string, change the result value to 1 to include the current string
        if (length >= low) result = 1;
        //Call the dfs method on all other strings with choice of adding either 0 * zero or 1 * one
        result += dfs(length + zero, high, low, zero, one, memo)  + dfs(length + one, high, low, zero, one, memo);
        //Add result to dp dict to eliminate repeated work
        memo[length] = (int)(result % mod);
        return memo[length];
    }
}
