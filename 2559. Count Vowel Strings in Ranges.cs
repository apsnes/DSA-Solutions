public class Solution
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        //Create answer array
        int[] ans = new int[queries.Length];
        //Create a set to store vowel characters and retrieve in O(1)
        HashSet<char> vowels = [ 'a', 'e', 'i', 'o', 'u' ];
        //Initialise an int array to keep track of prefix sum at each index
        int[] pre = new int[words.Length];
        //Variable to keep track of total sum of vowel strings
        int sum = 0;
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            //If the current word is a vowel string, increment sum
            if (vowels.Contains(word[0]) && vowels.Contains(word[^1]))
            {
                sum++;
            }
            //Add the sum for the current index to our prefix sum array
            pre[i] = sum;
        }
        //Iterate through each query
        for (int i = 0; i < queries.Length; i++)
        {
            //If the left bound of the query is 0, our result is simply
            //the value at the index of our right bound
            if (queries[i][0] == 0) ans[i] = pre[queries[i][1]];
            //If the left bound is not 0, we can calculate the result
            //by subtracting the left bound - 1 from the right bound of
            //the prefix sum array
            else ans[i] = pre[queries[i][1]] - pre[queries[i][0] - 1];
        }
        return ans;
    }
}
