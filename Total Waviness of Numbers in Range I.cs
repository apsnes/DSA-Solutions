public class Solution
{
    public int TotalWaviness(int num1, int num2)
    {
        var dp = new Dictionary<string, int>();
        var waviness = 0;

        for (int i = num1; i <= num2; i++)
        {
            var currString = i.ToString();
            if (currString.Length < 3) continue;
            if (dp.ContainsKey(currString)) waviness += dp[currString];
            var currWaviness = 0;
            for (int j = 1; j < currString.Length - 1; j++)
            {
                var currSubString = $"{currString[j - 1]}{currString[j]}{currString[j + 1]}";
                if (dp.ContainsKey(currSubString))
                {
                    currWaviness += dp[currSubString];
                }
                else
                {
                    var int0 = currSubString[0] - '0';
                    var int1 = currSubString[1] - '0';
                    var int2 = currSubString[2] - '0';
                    if ((int1 > int0 && int1 > int2) || (int1 < int0 && int1 < int2))
                    {
                        dp[currSubString] = 1;
                        currWaviness += 1;
                    }
                    else
                    {
                        dp[currSubString] = 0;
                    }
                }
            }
            dp[currString] = currWaviness;
            waviness += currWaviness;
        }

        return waviness;
    }
}
