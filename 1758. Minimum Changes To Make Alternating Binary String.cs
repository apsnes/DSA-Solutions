public class Solution
{
    public int MinOperations(string s)
    {
        var oneSteps = 0;
        var zeroSteps = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (s[i] == '1')
                {
                    zeroSteps++;
                }
                else
                {
                    oneSteps++;
                }
            }
            else
            {
                if (s[i] == '1')
                {
                    oneSteps++;
                }
                else
                {
                    zeroSteps++;
                }
            }
        }
        return Math.Min(zeroSteps, oneSteps);
    }
}
