public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int n = boxes.Length;
        int[] ans = new int[n];
        int ballsToLeft = 0, movesToLeft = 0, ballsToRight = 0, movesToRight = 0;
        for (int i = 0; i < n; i++)
        {
            ans[i] = movesToLeft;
            ballsToLeft += boxes[i] - '0';
            movesToLeft += ballsToLeft;
        }
        for (int i = n -1; i >= 0; i--)
        {
            ans[i] += movesToRight;
            ballsToRight += boxes[i] - '0';
            movesToRight += ballsToRight;
        }
        return ans;
    }
} 
